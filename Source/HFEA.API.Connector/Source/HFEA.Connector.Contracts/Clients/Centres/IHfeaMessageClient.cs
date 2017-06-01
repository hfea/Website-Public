using HFEA.Connector.Contracts.CentreDashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.Clients.Centres
{
    public interface IHfeaMessageClient
    {
        List<Message> GetClinicMessages(int clinicId);

        Message GetMessageById(int clinicId, int messageId);
    }
}
