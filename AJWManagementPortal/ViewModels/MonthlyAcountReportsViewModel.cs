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
        //- start---Variable for MonthlyClosingReport Account+DGM+GM+AccountError

        public bool IsMonthlyIncomeExpenceInternalAccountReport { get; set; }
        public bool IsTrialBalanceAccountOfficeReport { get; set; }
        public bool IsMonthlyClosingReport { get; set; }
        public bool IsMonthlyClosingReportDgm { get; set; }
        public bool IsMonthlyClosingReportGm { get; set; }
        public bool IsMonthlyClosingReportAccounts { get; set; }
        public bool IsMonthlyClosingReportAccountsError { get; set; }
        //-------ended----------------------
        //--start--Variable for MonthlyClosingReport Account+DGM+GM+AccountError
        public bool IsMeezanBankIncomeExpenseReport { get; set; }
        public bool IsMeezanBankIncomeExpenseReportDgm { get; set; }
        public bool IsMeezanBankIncomeExpenseReportGm { get; set; }
        public bool IsMeezanBankIncomeExpenseReportAccounts { get; set; }
        public bool IsMeezanBankIncomeExpenseReportAccountsError { get; set; }
        //---------------Ended----------------


        //------Its ViewActionName-------Start------For Accounts Monthly Report----
        private string _viewActionName;
        public string ViewActionName
        {
            get
            {
                if (IsMonthlyClosingReport)
                    _viewActionName = "EditMonthlyClosingReport";
                else if (IsMeezanBankIncomeExpenseReport)
                    _viewActionName = "EditMeezanBankIncomeExpenseReport";
                else if (IsMonthlyIncomeExpenceInternalAccountReport)
                    _viewActionName = "EditMonthlyIncomeExpenceInternalAccountReport";
                else if (IsTrialBalanceAccountOfficeReport)
                    _viewActionName = "EditTrialBalanceAccountOfficeReport";
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
        //------Its ViewActionName-----Ended--------For Accounts Monthly Report----

        //------Its Edit ActionName-----Start--------For Accounts Monthly Report----
        private string _editActionName;
        public string EditActionName
        {
            get
            {
                if (IsMonthlyClosingReport)
                    _editActionName = "EditMonthlyClosingReport";
                else if (IsMeezanBankIncomeExpenseReport)
                    _editActionName = "EditMeezanBankIncomeExpenseReport";
                else if (IsMonthlyIncomeExpenceInternalAccountReport)
                    _editActionName = "EditMonthlyIncomeExpenceInternalAccountReport";
                else if (IsTrialBalanceAccountOfficeReport)
                    _editActionName = "EditTrialBalanceAccountOfficeReport";
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
        //------Its EditActionName--------Ended-----For Accounts Monthly Report----

        //------Its Delete ActionName-------Start------For Accounts Monthly Report----

        private string _deleteActionName;
        public string DeleteActionName
        {
            get
            {
                if (IsMonthlyClosingReport)
                    _deleteActionName = "DeleteMonthlyClosingReport";
                else if (IsMeezanBankIncomeExpenseReport)
                    _deleteActionName = "DeleteMeezanBankIncomeExpenseReport";
                else if (IsMonthlyIncomeExpenceInternalAccountReport)
                    _deleteActionName = "DeleteMonthlyIncomeExpenceInternalAccountReport";
                else if (IsTrialBalanceAccountOfficeReport)
                    _deleteActionName = "DeleteTrialBalanceAccountOfficeReport";
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
        //------Its Delete ActionName---------Ended----For Accounts Monthly Report----

        //------Its Send ActionName------start-------For Accounts Monthly Report----

        private string _sendActionName;
        public string SendActionName
        {
            get
            {
                if (IsMonthlyClosingReport)
                    _sendActionName = "SendMonthlyClosingReportToDgmOffice";
                else if (IsMeezanBankIncomeExpenseReport)
                    _sendActionName = "SendMeezanBankIncomeExpenseReportToDgmOffice";
                else if (IsMonthlyIncomeExpenceInternalAccountReport)
                    _sendActionName = "SendMonthlyIncomeExpenceInternalAccountReport";
                else if (IsTrialBalanceAccountOfficeReport)
                    _sendActionName = "SendTrialBalanceAccountOfficeReport";
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
        //------Its Send ActionName------Ended-------For Accounts Monthly Report----

        //------Its @nd Send ActionName------start-------For Accounts Monthly Report----

        private string _secondSendActionName;
        public string SecondSendActionName
        {
            get
            {

                if (IsMonthlyClosingReportDgm)
                    _secondSendActionName = "SendMonthlyClosingReportToAccountErrorList";
                else if (IsMeezanBankIncomeExpenseReportDgm)
                    _secondSendActionName = "SendMeezanBankIncomeExpenseReportToAccountErrorList";
                //else if (IsMeezanBankIncomeExpenseReportDgm)
                //    _secondSendActionName = "SendMeezanBankIncomeExpenseReportToAccountErrorList";
                //else if (IsMeezanBankIncomeExpenseReportDgm)
                //    _secondSendActionName = "SendMeezanBankIncomeExpenseReportToAccountErrorList";
                else
                    _secondSendActionName = "";
                return _secondSendActionName;
            }
        }
        //------Its @nd Send ActionName------Ended-------For Accounts Monthly Report----

    }
}
