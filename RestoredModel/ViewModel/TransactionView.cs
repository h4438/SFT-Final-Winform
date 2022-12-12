using RestoredModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoredModel.ViewModel
{
    public class TransactionView
    {
        public int Id { get; set; }

        public int Quantity { get; set; }

        public int totalPrice { get; set; }

        // batch info
        public string Supplement { get; set; }

        // Agent
        public string AgentName { get; set; }
        public string AgentPhone { get; set; }
        // Agent Order
        public int OutOrderID { get; set; }
        public string AcceptDate { get; set; }

        public string Address { get; set; }


        public static TransactionView createView(AgentTransaction myAgentTransaction) 
        {
            TransactionView view = new TransactionView();
            view.Id = myAgentTransaction.Id;
            view.Quantity = myAgentTransaction.Quantity;
            view.Supplement = myAgentTransaction.SupplementBatch.Supplement.SName;
            int price = (int)myAgentTransaction.SupplementBatch.Supplement.price;
            view.totalPrice = price * view.Quantity;
            // agent
            view.AgentName = myAgentTransaction.AgentOrder.Agent.AgentName;
            view.AgentPhone = myAgentTransaction.AgentOrder.Agent.AgentPhone;
            //
            view.OutOrderID = myAgentTransaction.AgentOrder.OutOrderID;
            view.AcceptDate = myAgentTransaction.AgentOrder.AcceptDate;
            view.Address = myAgentTransaction.AgentOrder.Address;
            return view;
        }
    }
}
