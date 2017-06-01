using HFEA.BL.Contracts.Mapper;
using HFEA.Data.Contracts.Readers;
using HFEA.Web.ViewModel.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HFEA.Core;
using HFEA.Data.Contracts.DerivedModels;
using HFEA.Data.Contracts.Writers;
using HFEA.Web.ViewModel.Constants;
using HFEA.Data.Contracts.Model;

namespace HFEA.BL.ModelCreators.API
{
    public class PageCommentsUtility : IPageCommentsUtility
    {
        private readonly IPageCommentsReader dataReader;
        private readonly IMapper mapper;
        private readonly IPageCommentWriter dataWriter;

        public PageCommentsUtility(IPageCommentsReader commentsDataReader, IMapper contentMapper, IPageCommentWriter commentsDataWriter)
        {
            if (commentsDataReader == null) throw new ArgumentNullException("comments data reader is null");
            if (contentMapper == null) throw new ArgumentNullException("content mapper is null");
            if (commentsDataWriter == null) throw new ArgumentNullException("comments data writer is null");
                        
            this.dataReader = commentsDataReader;
            this.mapper = contentMapper;
            this.dataWriter = commentsDataWriter;
        }

        public PageCommentsApiViewModel GetCommentsData(int page, int pageSize, int? pageId, ApiConstants.ApprovalStatusFilter approvalStatus)
        {
            PageCommentsApiViewModel result = null;

            var rawData = pageId != null 
                ? this.dataReader.GetCommentsByPageId(pageId.Value, false)
                : this.dataReader.GetAllComments(false);

            if (approvalStatus == ApiConstants.ApprovalStatusFilter.Approved)
            {
                rawData = rawData.Where(x => x.IsApproved).ToList();
            }
            else if (approvalStatus == ApiConstants.ApprovalStatusFilter.NotApproved)
            {
                rawData = rawData.Where(x => !x.IsApproved).ToList();
            }            

            if (rawData != null && rawData.Any())
            {
                var paginatedRawData = new PagedList<PageComment>(rawData, page, pageSize, true);

                List<PageCommentsItem> mappedList = new List<PageCommentsItem>();

                foreach (var item in paginatedRawData)
                {
                    var mapped = this.mapper.Map<BaseCmsContent>(item.PageId);
                    mappedList.Add(new PageCommentsItem()
                    {
                        Id = item.Id,
                        PageId = item.PageId,
                        PageTitle = mapped?.Name ?? "page not found",
                        PageUrl = mapped?.Url,
                        IsApproved = item.IsApproved,
                        ModifiedBy = item.ModifiedBy,
                        ParentId = item.ParentId,
                        Text = item.Text,
                        UserEmail = item.Email,
                        UserFullName = string.Format("{0} {1}", item.Name, item.Lastname).Trim(),
                        DateCreated = item.CreatedDate.ToHFEADateTimeString(),
                        DateModified = item.ModifiedDate.ToHFEADateTimeStringOrEmpty()
                    });
                }

                result = new PageCommentsApiViewModel()
                {
                    Comments = mappedList,
                    PaginationData = new Web.ViewModel.PaginationModel()
                    {
                        Page = paginatedRawData.Page,
                        PageSize = paginatedRawData.PageSize,
                        TotalRecords = paginatedRawData.TotalRecords
                    }
                };
            }

            return result;
        }

        public bool DeleteComment(int commentId)
        {
            bool result = false;
            if (commentId > 0)
            {
                result = this.dataWriter.DeleteComment(commentId);
            }

            return result;
        }

        public bool UpdateComment(PageCommentsItem comment)
        {
            bool result = false;

            if (comment != null && comment.Id > 0)
            {
                PageComment updatedComment = this.dataReader.GetCommentById(comment.Id);

                if (updatedComment != null)
                {
                    updatedComment.Text = comment.Text.AntiXssEncode();
                    updatedComment.ModifiedBy = comment.ModifiedBy;
                    updatedComment.ModifiedDate = DateTime.UtcNow;
                    updatedComment.IsApproved = comment.IsApproved;

                    result = this.dataWriter.UpdateComment(updatedComment);
                }
            }

            return result;
        }
    }
}
