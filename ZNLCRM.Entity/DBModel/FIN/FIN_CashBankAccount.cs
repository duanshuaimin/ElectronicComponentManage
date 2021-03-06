//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by CodeSmith Template.
//
//     Creater: David
//     Date:    2014/11/6
//     Time:    17:53
//     Version: 4.0.0.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

/// <summary>
/// CodeSmith自动生成的实体
/// </summary>
namespace ZNLCRM.Entity.DBModel
{
    using System;
    using MySoft.Data;
    using ZNLCRM.Utility;
    using ZNLFrame.Entity;
    /// <summary>
    /// 表名：FIN_CashBankAccount 主键列：CBID
    /// </summary>
    [SerializableAttribute()]
    public partial class FIN_CashBankAccount : BaseEntity
    {
        #region Private Properties

        private Int32 _CBID;
        private Guid? _CBGuid;
        private String _CBNo;
        private String _CBName;
        private Guid? _GCompanyID;
        private String _Currency;
        private String _BCode;
        private String _BAddress;
        private String _BTelephone;
        private String _BFax;
        private Boolean? _IsFrozen;
        private Int32? _ManagerID;
        private String _ManagerName;
        private Decimal? _Amount;
        private String _Remark;
        private Int32? _CreatedEmpID;
        private String _CreatedEmpName;
        private DateTime? _CreatedTime;
        private Int32? _UpdatedEmpID;
        private String _UpdatedEmpName;
        private DateTime? _UpdatedTime;
        private Boolean? _IsDeleted;

        #endregion

        #region Public Properties

        /// <summary>
        /// .
        /// </summary>
        public Int32 CBID
        {
            get
            {
                return _CBID;
            }
            set
            {
                this.OnPropertyValueChange(_.CBID, _CBID, value);
                this._CBID = value;
            }
        }

        /// <summary>
        /// .
        /// </summary>
        public Guid? CBGuid
        {
            get
            {
                return this._CBGuid;
            }
            set
            {
                this.OnPropertyValueChange(_.CBGuid, _CBGuid, value);
                this._CBGuid = value;
            }
        }

        /// <summary>
        /// 帐户代码.
        /// </summary>
        public String CBNo
        {
            get
            {
                return this._CBNo;
            }
            set
            {
                this.OnPropertyValueChange(_.CBNo, _CBNo, value);
                this._CBNo = value.SubStr(50);
            }
        }

        /// <summary>
        /// 帐户名称.
        /// </summary>
        public String CBName
        {
            get
            {
                return this._CBName;
            }
            set
            {
                this.OnPropertyValueChange(_.CBName, _CBName, value);
                this._CBName = value.SubStr(50);
            }
        }

        /// <summary>
        /// 所属公司GUID.
        /// </summary>
        public Guid? GCompanyID
        {
            get
            {
                return this._GCompanyID;
            }
            set
            {
                this.OnPropertyValueChange(_.GCompanyID, _GCompanyID, value);
                this._GCompanyID = value;
            }
        }

        /// <summary>
        /// 币种.
        /// </summary>
        public String Currency
        {
            get
            {
                return this._Currency;
            }
            set
            {
                this.OnPropertyValueChange(_.Currency, _Currency, value);
                this._Currency = value.SubStr(10);
            }
        }

        /// <summary>
        /// 银行编码.
        /// </summary>
        public String BCode
        {
            get
            {
                return this._BCode;
            }
            set
            {
                this.OnPropertyValueChange(_.BCode, _BCode, value);
                this._BCode = value.SubStr(50);
            }
        }

        /// <summary>
        /// 银行地址.
        /// </summary>
        public String BAddress
        {
            get
            {
                return this._BAddress;
            }
            set
            {
                this.OnPropertyValueChange(_.BAddress, _BAddress, value);
                this._BAddress = value.SubStr(300);
            }
        }

        /// <summary>
        /// 银行电话.
        /// </summary>
        public String BTelephone
        {
            get
            {
                return this._BTelephone;
            }
            set
            {
                this.OnPropertyValueChange(_.BTelephone, _BTelephone, value);
                this._BTelephone = value.SubStr(100);
            }
        }

        /// <summary>
        /// 银行传真.
        /// </summary>
        public String BFax
        {
            get
            {
                return this._BFax;
            }
            set
            {
                this.OnPropertyValueChange(_.BFax, _BFax, value);
                this._BFax = value.SubStr(100);
            }
        }

        /// <summary>
        /// 冻结.
        /// </summary>
        public Boolean? IsFrozen
        {
            get
            {
                return this._IsFrozen;
            }
            set
            {
                this.OnPropertyValueChange(_.IsFrozen, _IsFrozen, value);
                this._IsFrozen = value;
            }
        }

        /// <summary>
        /// 帐户管理人ID.
        /// </summary>
        public Int32? ManagerID
        {
            get
            {
                return this._ManagerID;
            }
            set
            {
                this.OnPropertyValueChange(_.ManagerID, _ManagerID, value);
                this._ManagerID = value;
            }
        }

        /// <summary>
        /// 帐户管理人.
        /// </summary>
        public String ManagerName
        {
            get
            {
                return this._ManagerName;
            }
            set
            {
                this.OnPropertyValueChange(_.ManagerName, _ManagerName, value);
                this._ManagerName = value.SubStr(50);
            }
        }

        /// <summary>
        /// 金额.
        /// </summary>
        public Decimal? Amount
        {
            get
            {
                return this._Amount;
            }
            set
            {
                this.OnPropertyValueChange(_.Amount, _Amount, value);
                this._Amount = value;
            }
        }

        /// <summary>
        /// 备注.
        /// </summary>
        public String Remark
        {
            get
            {
                return this._Remark;
            }
            set
            {
                this.OnPropertyValueChange(_.Remark, _Remark, value);
                this._Remark = value.SubStr(50);
            }
        }

        /// <summary>
        /// .
        /// </summary>
        public Int32? CreatedEmpID
        {
            get
            {
                return this._CreatedEmpID;
            }
            set
            {
                this.OnPropertyValueChange(_.CreatedEmpID, _CreatedEmpID, value);
                this._CreatedEmpID = value;
            }
        }

        /// <summary>
        /// .
        /// </summary>
        public String CreatedEmpName
        {
            get
            {
                return this._CreatedEmpName;
            }
            set
            {
                this.OnPropertyValueChange(_.CreatedEmpName, _CreatedEmpName, value);
                this._CreatedEmpName = value.SubStr(50);
            }
        }

        /// <summary>
        /// .
        /// </summary>
        public DateTime? CreatedTime
        {
            get
            {
                return this._CreatedTime;
            }
            set
            {
                this.OnPropertyValueChange(_.CreatedTime, _CreatedTime, value);
                this._CreatedTime = value;
            }
        }

        /// <summary>
        /// .
        /// </summary>
        public Int32? UpdatedEmpID
        {
            get
            {
                return this._UpdatedEmpID;
            }
            set
            {
                this.OnPropertyValueChange(_.UpdatedEmpID, _UpdatedEmpID, value);
                this._UpdatedEmpID = value;
            }
        }

        /// <summary>
        /// .
        /// </summary>
        public String UpdatedEmpName
        {
            get
            {
                return this._UpdatedEmpName;
            }
            set
            {
                this.OnPropertyValueChange(_.UpdatedEmpName, _UpdatedEmpName, value);
                this._UpdatedEmpName = value.SubStr(50);
            }
        }

        /// <summary>
        /// .
        /// </summary>
        public DateTime? UpdatedTime
        {
            get
            {
                return this._UpdatedTime;
            }
            set
            {
                this.OnPropertyValueChange(_.UpdatedTime, _UpdatedTime, value);
                this._UpdatedTime = value;
            }
        }

        /// <summary>
        /// 删除标记.
        /// </summary>
        public Boolean? IsDeleted
        {
            get
            {
                return this._IsDeleted;
            }
            set
            {
                this.OnPropertyValueChange(_.IsDeleted, _IsDeleted, value);
                this._IsDeleted = value;
            }
        }

        #endregion
        /// <summary>
        /// 获取实体对应的表名
        /// </summary>
        protected override Table GetTable()
        {
            return new Table<FIN_CashBankAccount>("FIN_CashBankAccount");
        }

        /// <summary>
        /// 获取实体中的标识列
        /// </summary>
        protected override Field GetIdentityField()
        {
            return _.CBID;
        }

        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        protected override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
				_.CBID
			};
        }

        /// <summary>
        /// 获取列信息
        /// </summary>
        protected override Field[] GetFields()
        {
            return new Field[] {
				_.CBID,		
				_.CBGuid,		
				_.CBNo,		
				_.CBName,		
				_.GCompanyID,		
				_.Currency,		
				_.BCode,		
				_.BAddress,		
				_.BTelephone,		
				_.BFax,		
				_.IsFrozen,		
				_.ManagerID,		
				_.ManagerName,		
				_.Amount,		
				_.Remark,		
				_.CreatedEmpID,		
				_.CreatedEmpName,		
				_.CreatedTime,		
				_.UpdatedEmpID,		
				_.UpdatedEmpName,		
				_.UpdatedTime,		
				_.IsDeleted		
			};
        }

        /// <summary>
        /// 获取列数据
        /// </summary>
        protected override object[] GetValues()
        {
            return new object[] {
				this._CBID,		
				this._CBGuid,		
				this._CBNo,		
				this._CBName,		
				this._GCompanyID,		
				this._Currency,		
				this._BCode,		
				this._BAddress,		
				this._BTelephone,		
				this._BFax,		
				this._IsFrozen,		
				this._ManagerID,		
				this._ManagerName,		
				this._Amount,		
				this._Remark,		
				this._CreatedEmpID,		
				this._CreatedEmpName,		
				this._CreatedTime,		
				this._UpdatedEmpID,		
				this._UpdatedEmpName,		
				this._UpdatedTime,		
				this._IsDeleted		
			};
        }

        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        protected override void SetValues(IRowReader reader)
        {
            if ((false == reader.IsDBNull(_.CBID)))
            {
                this._CBID = reader.GetInt32(_.CBID);
            }
            if ((false == reader.IsDBNull(_.CBGuid)))
            {
                this._CBGuid = reader.GetGuid(_.CBGuid);
            }
            if ((false == reader.IsDBNull(_.CBNo)))
            {
                this._CBNo = reader.GetString(_.CBNo);
            }
            if ((false == reader.IsDBNull(_.CBName)))
            {
                this._CBName = reader.GetString(_.CBName);
            }
            if ((false == reader.IsDBNull(_.GCompanyID)))
            {
                this._GCompanyID = reader.GetGuid(_.GCompanyID);
            }
            if ((false == reader.IsDBNull(_.Currency)))
            {
                this._Currency = reader.GetString(_.Currency);
            }
            if ((false == reader.IsDBNull(_.BCode)))
            {
                this._BCode = reader.GetString(_.BCode);
            }
            if ((false == reader.IsDBNull(_.BAddress)))
            {
                this._BAddress = reader.GetString(_.BAddress);
            }
            if ((false == reader.IsDBNull(_.BTelephone)))
            {
                this._BTelephone = reader.GetString(_.BTelephone);
            }
            if ((false == reader.IsDBNull(_.BFax)))
            {
                this._BFax = reader.GetString(_.BFax);
            }
            if ((false == reader.IsDBNull(_.IsFrozen)))
            {
                this._IsFrozen = reader.GetBoolean(_.IsFrozen);
            }
            if ((false == reader.IsDBNull(_.ManagerID)))
            {
                this._ManagerID = reader.GetInt32(_.ManagerID);
            }
            if ((false == reader.IsDBNull(_.ManagerName)))
            {
                this._ManagerName = reader.GetString(_.ManagerName);
            }
            if ((false == reader.IsDBNull(_.Amount)))
            {
                this._Amount = reader.GetDecimal(_.Amount);
            }
            if ((false == reader.IsDBNull(_.Remark)))
            {
                this._Remark = reader.GetString(_.Remark);
            }
            if ((false == reader.IsDBNull(_.CreatedEmpID)))
            {
                this._CreatedEmpID = reader.GetInt32(_.CreatedEmpID);
            }
            if ((false == reader.IsDBNull(_.CreatedEmpName)))
            {
                this._CreatedEmpName = reader.GetString(_.CreatedEmpName);
            }
            if ((false == reader.IsDBNull(_.CreatedTime)))
            {
                this._CreatedTime = reader.GetDateTime(_.CreatedTime);
            }
            if ((false == reader.IsDBNull(_.UpdatedEmpID)))
            {
                this._UpdatedEmpID = reader.GetInt32(_.UpdatedEmpID);
            }
            if ((false == reader.IsDBNull(_.UpdatedEmpName)))
            {
                this._UpdatedEmpName = reader.GetString(_.UpdatedEmpName);
            }
            if ((false == reader.IsDBNull(_.UpdatedTime)))
            {
                this._UpdatedTime = reader.GetDateTime(_.UpdatedTime);
            }
            if ((false == reader.IsDBNull(_.IsDeleted)))
            {
                this._IsDeleted = reader.GetBoolean(_.IsDeleted);
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if ((obj == null))
            {
                return false;
            }
            if ((false == typeof(FIN_CashBankAccount).IsAssignableFrom(obj.GetType())))
            {
                return false;
            }
            if ((((object)(this)) == ((object)(obj))))
            {
                return true;
            }
            return false;
        }

        public class _
        {

            /// <summary>
            /// 表示选择所有列，与*等同
            /// </summary>
            public static AllField All = new AllField<FIN_CashBankAccount>();

            /// <summary>
            ///  - 字段名：CBID - 数据类型：Int32?
            /// </summary>
            public static Field CBID = new Field<FIN_CashBankAccount>("CBID");
            /// <summary>
            ///  - 字段名：CBGuid - 数据类型：Guid?
            /// </summary>
            public static Field CBGuid = new Field<FIN_CashBankAccount>("CBGuid");
            /// <summary>
            /// 帐户代码 - 字段名：CBNo - 数据类型：String
            /// </summary>
            public static Field CBNo = new Field<FIN_CashBankAccount>("CBNo");
            /// <summary>
            /// 帐户名称 - 字段名：CBName - 数据类型：String
            /// </summary>
            public static Field CBName = new Field<FIN_CashBankAccount>("CBName");
            /// <summary>
            /// 所属公司GUID - 字段名：GCompanyID - 数据类型：Guid?
            /// </summary>
            public static Field GCompanyID = new Field<FIN_CashBankAccount>("GCompanyID");
            /// <summary>
            /// 币种 - 字段名：Currency - 数据类型：String
            /// </summary>
            public static Field Currency = new Field<FIN_CashBankAccount>("Currency");
            /// <summary>
            /// 银行编码 - 字段名：BCode - 数据类型：String
            /// </summary>
            public static Field BCode = new Field<FIN_CashBankAccount>("BCode");
            /// <summary>
            /// 银行地址 - 字段名：BAddress - 数据类型：String
            /// </summary>
            public static Field BAddress = new Field<FIN_CashBankAccount>("BAddress");
            /// <summary>
            /// 银行电话 - 字段名：BTelephone - 数据类型：String
            /// </summary>
            public static Field BTelephone = new Field<FIN_CashBankAccount>("BTelephone");
            /// <summary>
            /// 银行传真 - 字段名：BFax - 数据类型：String
            /// </summary>
            public static Field BFax = new Field<FIN_CashBankAccount>("BFax");
            /// <summary>
            /// 冻结 - 字段名：IsFrozen - 数据类型：Boolean?
            /// </summary>
            public static Field IsFrozen = new Field<FIN_CashBankAccount>("IsFrozen");
            /// <summary>
            /// 帐户管理人ID - 字段名：ManagerID - 数据类型：Int32?
            /// </summary>
            public static Field ManagerID = new Field<FIN_CashBankAccount>("ManagerID");
            /// <summary>
            /// 帐户管理人 - 字段名：ManagerName - 数据类型：String
            /// </summary>
            public static Field ManagerName = new Field<FIN_CashBankAccount>("ManagerName");
            /// <summary>
            /// 金额 - 字段名：Amount - 数据类型：Decimal?
            /// </summary>
            public static Field Amount = new Field<FIN_CashBankAccount>("Amount");
            /// <summary>
            /// 备注 - 字段名：Remark - 数据类型：String
            /// </summary>
            public static Field Remark = new Field<FIN_CashBankAccount>("Remark");
            /// <summary>
            ///  - 字段名：CreatedEmpID - 数据类型：Int32?
            /// </summary>
            public static Field CreatedEmpID = new Field<FIN_CashBankAccount>("CreatedEmpID");
            /// <summary>
            ///  - 字段名：CreatedEmpName - 数据类型：String
            /// </summary>
            public static Field CreatedEmpName = new Field<FIN_CashBankAccount>("CreatedEmpName");
            /// <summary>
            ///  - 字段名：CreatedTime - 数据类型：DateTime?
            /// </summary>
            public static Field CreatedTime = new Field<FIN_CashBankAccount>("CreatedTime");
            /// <summary>
            ///  - 字段名：UpdatedEmpID - 数据类型：Int32?
            /// </summary>
            public static Field UpdatedEmpID = new Field<FIN_CashBankAccount>("UpdatedEmpID");
            /// <summary>
            ///  - 字段名：UpdatedEmpName - 数据类型：String
            /// </summary>
            public static Field UpdatedEmpName = new Field<FIN_CashBankAccount>("UpdatedEmpName");
            /// <summary>
            ///  - 字段名：UpdatedTime - 数据类型：DateTime?
            /// </summary>
            public static Field UpdatedTime = new Field<FIN_CashBankAccount>("UpdatedTime");
            /// <summary>
            /// 删除标记 - 字段名：IsDeleted - 数据类型：Boolean?
            /// </summary>
            public static Field IsDeleted = new Field<FIN_CashBankAccount>("IsDeleted");
        }
    }
}
