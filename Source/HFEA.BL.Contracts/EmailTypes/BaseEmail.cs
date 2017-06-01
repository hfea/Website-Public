using HFEA.BL.Contracts.Mapper;
using HFEA.BL.Contracts.Mapper.Email;
using System;
using System.Collections.Generic;

namespace HFEA.BL.Contracts.EmailTypes
{
    public class BaseEmail
    {
        private readonly int nodeId;
        private readonly IMapper mapper;
                    
        public BaseEmail(IMapper contentMapper, int emailNodeId)
        {
            if (emailNodeId < 1) throw new ArgumentOutOfRangeException("email node id value is not valid");
            if (contentMapper == null) throw new ArgumentNullException("CMS content mapper is null");

            this.mapper = contentMapper;
            this.nodeId = emailNodeId;
        }

        public virtual Email GetEmailObject(Dictionary<string, string> replacements)
        {
            EmailTemplate mappedEmail = this.mapper.Map<EmailTemplate>(nodeId);
            Email email = this.PopulateCommonFields(mappedEmail, replacements);

            return email;
        }

        public virtual Email GetEmailObject(Dictionary<string, string> replacements, string to, string from)
        {
            Email email = this.GetEmailObject(replacements);

            if (email != null)
            {
                if (!string.IsNullOrWhiteSpace(to))
                {
                    email.ToAddress = to;
                }

                if (!string.IsNullOrWhiteSpace(from))
                {
                    email.FromAddress = from;
                }
            }

            return email;
        }

        protected Email PopulateCommonFields(EmailTemplate mappedEmail, Dictionary<string, string> replacements)
        {
            if (mappedEmail != null)
            {
                Email email = new Email();
                email.ToAddress = mappedEmail.To;
                email.FromAddress = mappedEmail.From;
                email.CcAddress = mappedEmail.CC;
                email.BccAddress = mappedEmail.BCC;
                email.Subject = this.FillPlaceholders(mappedEmail.EmailSubject, replacements, false);
                email.BodyText = this.FillPlaceholders(mappedEmail.BodyText, replacements, false);
                email.BodyHTML = this.FillPlaceholders(mappedEmail.EmailBodyHtml, replacements, true);
                return email;
            }

            return null;

        }


        protected string FillPlaceholders(string emailField, Dictionary<string, string> replacements, bool isHtml)
        {
            if (!string.IsNullOrEmpty(emailField) && replacements != null)
            {
                foreach (KeyValuePair<string, string> dictionaryItem in replacements)
                {
                    string value = dictionaryItem.Value ?? string.Empty;
                    string key = dictionaryItem.Key;

                    if (!key.StartsWith("%"))
                    {
                        key = "%" + dictionaryItem.Key + "%";
                    }

                    if (isHtml)
                    {
                        emailField = emailField.Replace(key, value.Replace("\r\n", "<br />"));
                    }
                    else
                    {
                        emailField = emailField.Replace(key, value);
                    }
                }
            }

            return emailField;
        }
    }
}
