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
        public bool IsMonthlyClosingReportDgm { get; set; }
        public bool IsMonthlyClosingReportGm { get; set; }
        public bool IsMonthlyClosingReportAccounts { get; set; }
        public bool IsMonthlyClosingReportAccountsError { get; set; }
        public bool IsMeezanBankIncomeExpenseReport { get; set; }
        public bool IsMeezanBankIncomeExpenseReportDgm { get; set; }
        public bool IsMeezanBankIncomeExpenseReportGm { get; set; }
        public bool IsMeezanBankIncomeExpenseReportAccounts { get; set; } 
        public bool IsMeezanBankIncomeExpenseReportAccountsError { get; set; }




        private string _viewActionName;
        public string ViewActionName
        {
            get
            {
                if (IsMonthlyClosingReport)
                    _viewActionName = "EditMonthlyClosingReport";
                else if (IsMeezanBankIncomeExpenseReport)
                    _viewActionName = "EditMeezanBankIncomeExpenseReport";
                else if (IsMonthlyClosingReportDgm)
                    _viewActionName = "EditMonthlyClosingReport";
                else if (IsMeezanBankIncomeExpenseReportDgm)
                    _viewActionName = "EditMeezanBankIncomeExpenseReport";
                else if (IsMonthlyClosingReportGm)
                    _viewActionName = "EditMonthlyClosingReport";
                else if (IsMeezanBankIncomeExpenseReportGm)
                    _viewActionName = "EditMeezanBankIncomeExpenseReport";
                else if (IsMonthlyClosingReportAccounts)
                    _viewActionName = "EditMonthlyClosingReport";
                else if (IsMeezanBankIncomeExpenseReportAccounts)
                    _viewActionName = "EditMeezanBankIncomeExpenseReport";
                else if (IsMonthlyClosingReportAccountsError)
                    _viewActionName = "EditMonthlyClosingReport";
                else if (IsMeezanBankIncomeExpenseReportAccountsError)
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
                else if (IsMonthlyClosingReportDgm)
                    _editActionName = "EditMonthlyClosingReport";
                else if (IsMeezanBankIncomeExpenseReportDgm)
                    _editActionName = "EditMeezanBankIncomeExpenseReport";
                else if (IsMonthlyClosingReportGm)
                    _editActionName = "EditMonthlyClosingReport";
                else if (IsMeezanBankIncomeExpenseReportGm)
                    _editActionName = "EditMeezanBankIncomeExpenseReport";
                else if (IsMonthlyClosingReportAccounts)
                    _editActionName = "EditMonthlyClosingReport";
                else if (IsMeezanBankIncomeExpenseReportAccounts)
                    _editActionName = "EditMeezanBankIncomeExpenseReport";
                else if (IsMonthlyClosingReportAccountsError)
                    _editActionName = "EditMonthlyClosingReport";
                else if (IsMeezanBankIncomeExpenseReportAccountsError)
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
                else if (IsMonthlyClosingReportDgm)
                    _deleteActionName = "DeleteMonthlyClosingReport";
                else if (IsMeezanBankIncomeExpenseReportDgm)
                    _deleteActionName = "DeleteMeezanBankIncomeExpenseReport";
                else if (IsMonthlyClosingReportGm)
                    _deleteActionName = "DeleteMonthlyClosingReport";
                else if (IsMeezanBankIncomeExpenseReportGm)
                    _deleteActionName = "DeleteMeezanBankIncomeExpenseReport";
                else if (IsMonthlyClosingReportAccounts)
                    _deleteActionName = "DeleteMonthlyClosingReportAccountOffice";
                else if (IsMeezanBankIncomeExpenseReportAccounts)
                    _deleteActionName = "DeleteMeezanBankIncomeExpenseReport";
                else if (IsMonthlyClosingReportAccountsError)
                    _deleteActionName = "DeleteMonthlyClosingReportAccountErrorList";
                else if (IsMeezanBankIncomeExpenseReportAccountsError)
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
                else if (IsMonthlyClosingReportDgm)
                    _sendActionName = "SendMonthlyClosingReportToGmOffice";
                else if (IsMeezanBankIncomeExpenseReportDgm)
                    _sendActionName = "SendMeezanBankIncomeExpenseReportToGmOffice";
                else if (IsMonthlyClosingReportGm)
                    _sendActionName = "SendMonthlyClosingReportToAccountOffice";
                else if (IsMeezanBankIncomeExpenseReportGm)
                    _sendActionName = "SendMeezanBankIncomeExpenseReportToAccountOffice";
                else if (IsMonthlyClosingReportAccounts)
                    _sendActionName = "SendMonthlyClosingReportToAccountOffice";
                else if (IsMeezanBankIncomeExpenseReportAccounts)
                    _sendActionName = "SendMeezanBankIncomeExpenseReportToAccountOffice";
                else if (IsMonthlyClosingReportAccountsError)
                    _sendActionName = "SendMonthlyClosingReportToDgmOffice";
                else if (IsMeezanBankIncomeExpenseReportAccountsError)
                    _sendActionName = "SendMeezanBankIncomeExpenseReportToAccountErrorList";
                else
                    _sendActionName = "";
                return _sendActionName;
            }
        }
        private string _secondSendActionName;
        public string SecondSendActionName
        {
            get
            {
               
                 if (IsMonthlyClosingReportDgm)
                    _secondSendActionName = "SendMonthlyClosingReportToAccountErrorList";
                else if (IsMeezanBankIncomeExpenseReportDgm)
                    _secondSendActionName = "SendMeezanBankIncomeExpenseReportToAccountErrorList";
                else
                    _secondSendActionName = "";
                return _secondSendActionName;
            }
        }
    }
}
