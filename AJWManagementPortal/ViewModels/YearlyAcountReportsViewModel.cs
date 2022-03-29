using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.ViewModels
{
    public class YearlyAcountReportsViewModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public bool IsYearlyClosingReport { get; set; }
        public bool IsYearlyClosingReportDgm { get; set; }
        public bool IsYearlyClosingReportGm { get; set; }
        public bool IsYearlyClosingReportAccounts { get; set; }
        public bool IsYearlyClosingReportAccountsError { get; set; }
        //public bool IsMeezanBankIncomeExpenseReport { get; set; }
        //public bool IsMeezanBankIncomeExpenseReportDgm { get; set; }
        //public bool IsMeezanBankIncomeExpenseReportGm { get; set; }
        //public bool IsMeezanBankIncomeExpenseReportAccounts { get; set; }
        //public bool IsMeezanBankIncomeExpenseReportAccountsError { get; set; }




        private string _viewActionName;
        public string ViewActionName
        {
            get
            {
                if (IsYearlyClosingReport)
                    _viewActionName = "EditYearlyClosingReport";
                //else if (IsMeezanBankIncomeExpenseReport)
                //    _viewActionName = "EditMeezanBankIncomeExpenseReport";
                else if (IsYearlyClosingReportDgm)
                    _viewActionName = "EditYearlyClosingReport";
                //else if (IsMeezanBankIncomeExpenseReportDgm)
                //    _viewActionName = "EditMeezanBankIncomeExpenseReport";
                else if (IsYearlyClosingReportGm)
                    _viewActionName = "EditYearlyClosingReport";
                //else if (IsMeezanBankIncomeExpenseReportGm)
                //    _viewActionName = "EditMeezanBankIncomeExpenseReport";
                else if (IsYearlyClosingReportAccounts)
                    _viewActionName = "EditYearlyClosingReport";
                //else if (IsMeezanBankIncomeExpenseReportAccounts)
                //    _viewActionName = "EditMeezanBankIncomeExpenseReport";
                else if (IsYearlyClosingReportAccountsError)
                    _viewActionName = "EditYearlyClosingReport";
                //else if (IsMeezanBankIncomeExpenseReportAccountsError)
                //    _viewActionName = "EditMeezanBankIncomeExpenseReport";
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
                if (IsYearlyClosingReport)
                    _editActionName = "EditYearlyClosingReport";
                //else if (IsMeezanBankIncomeExpenseReport)
                //    _editActionName = "EditMeezanBankIncomeExpenseReport";
                else if (IsYearlyClosingReportDgm)
                    _editActionName = "EditYearlyClosingReport";
                //else if (IsMeezanBankIncomeExpenseReportDgm)
                //    _editActionName = "EditMeezanBankIncomeExpenseReport";
                else if (IsYearlyClosingReportGm)
                    _editActionName = "EditYearlyClosingReport";
                //else if (IsMeezanBankIncomeExpenseReportGm)
                //    _editActionName = "EditMeezanBankIncomeExpenseReport";
                else if (IsYearlyClosingReportAccounts)
                    _editActionName = "EditYearlyClosingReport";
                //else if (IsMeezanBankIncomeExpenseReportAccounts)
                //    _editActionName = "EditMeezanBankIncomeExpenseReport";
                else if (IsYearlyClosingReportAccountsError)
                    _editActionName = "EditYearlyClosingReport";
                //else if (IsMeezanBankIncomeExpenseReportAccountsError)
                //    _editActionName = "EditMeezanBankIncomeExpenseReport";
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
                if (IsYearlyClosingReport)
                    _deleteActionName = "DeleteYearlyClosingReport";
                //else if (IsMeezanBankIncomeExpenseReport)
                //    _deleteActionName = "DeleteMeezanBankIncomeExpenseReport";
                else if (IsYearlyClosingReportDgm)
                    _deleteActionName = "DeleteYearlyClosingReport";
                //else if (IsMeezanBankIncomeExpenseReportDgm)
                //    _deleteActionName = "DeleteMeezanBankIncomeExpenseReport";
                else if (IsYearlyClosingReportGm)
                    _deleteActionName = "DeleteYearlyClosingReport";
                //else if (IsMeezanBankIncomeExpenseReportGm)
                //    _deleteActionName = "DeleteMeezanBankIncomeExpenseReport";
                else if (IsYearlyClosingReportAccounts)
                    _deleteActionName = "DeleteYearlyClosingReportAccountOffice";
                //else if (IsMeezanBankIncomeExpenseReportAccounts)
                //    _deleteActionName = "DeleteMeezanBankIncomeExpenseReport";
                else if (IsYearlyClosingReportAccountsError)
                    _deleteActionName = "DeleteYearlyClosingReportAccountErrorList";
                //else if (IsMeezanBankIncomeExpenseReportAccountsError)
                //    _deleteActionName = "DeleteMeezanBankIncomeExpenseReport";
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
                if (IsYearlyClosingReport)
                    _sendActionName = "SendYearlyClosingReportToDgmOffice";
                //else if (IsMeezanBankIncomeExpenseReport)
                //    _sendActionName = "SendMeezanBankIncomeExpenseReportToDgmOffice";
                else if (IsYearlyClosingReportDgm)
                    _sendActionName = "SendYearlyClosingReportToGmOffice";
                //else if (IsMeezanBankIncomeExpenseReportDgm)
                //    _sendActionName = "SendMeezanBankIncomeExpenseReportToGmOffice";
                else if (IsYearlyClosingReportGm)
                    _sendActionName = "SendYearlyClosingReportToAccountOffice";
                //else if (IsMeezanBankIncomeExpenseReportGm)
                //    _sendActionName = "SendMeezanBankIncomeExpenseReportToAccountOffice";
                else if (IsYearlyClosingReportAccounts)
                    _sendActionName = "SendYearlyClosingReportToAccountOffice";
                //else if (IsMeezanBankIncomeExpenseReportAccounts)
                //    _sendActionName = "SendMeezanBankIncomeExpenseReportToAccountOffice";
                else if (IsYearlyClosingReportAccountsError)
                    _sendActionName = "SendYearlyClosingReportToDgmOffice";
                //else if (IsMeezanBankIncomeExpenseReportAccountsError)
                //    _sendActionName = "SendMeezanBankIncomeExpenseReportToAccountErrorList";
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

                if (IsYearlyClosingReportDgm)
                    _secondSendActionName = "SendYearlyClosingReportToAccountErrorList";
                //else if (IsMeezanBankIncomeExpenseReportDgm)
                //    _secondSendActionName = "SendMeezanBankIncomeExpenseReportToAccountErrorList";
                else
                    _secondSendActionName = "";
                return _secondSendActionName;
            }
        }
    }
}

