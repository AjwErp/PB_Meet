using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.ViewModels
{
    public class MonthlyAcountReportsViewModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public bool IsMonthlyClosingReport { get; set; }
        public bool IsMeezanBankIncomeExpenseReport { get; set; }

        private string _viewActionName;
        public string ViewActionName
        {
            get
            {
                if (IsMonthlyClosingReport)
                    _viewActionName = "EditMonthlyClosingReport";
                else if (IsMeezanBankIncomeExpenseReport)
                    _viewActionName = "EditMeezanBankIncomeExpenseReport";
                else
                    _viewActionName = "";
                return _viewActionName;
            }
        }

        private string _editActionName;
        public string EditActionName
        {
            get
            {
                if (IsMonthlyClosingReport)
                    _editActionName = "EditMonthlyClosingReport";
                else if (IsMeezanBankIncomeExpenseReport)
                    _editActionName = "EditMeezanBankIncomeExpenseReport";
                else
                    _editActionName = "";
                return _editActionName;
            }

        }

        private string _deleteActionName;
        public string DeleteActionName
        {
            get
            {
                if (IsMonthlyClosingReport)
                    _deleteActionName = "DeleteMonthlyClosingReport";
                else if (IsMeezanBankIncomeExpenseReport)
                    _deleteActionName = "DeleteMeezanBankIncomeExpenseReport";
                else
                    _deleteActionName = "";
                return _deleteActionName;
            }

        }

        private string _sendActionName;
        public string SendActionName
        {
            get
            {
                if (IsMonthlyClosingReport)
                    _sendActionName = "SendMonthlyClosingReportToDgmOffice";
                else if (IsMeezanBankIncomeExpenseReport)
                    _sendActionName = "SendMeezanBankIncomeExpenseReportToDgmOffice";
                else
                    _sendActionName = "";
                return _sendActionName;
            }
        }
    }
}
