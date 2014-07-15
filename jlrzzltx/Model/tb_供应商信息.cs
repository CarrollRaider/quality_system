using System;
namespace gzpi.Model
{
	/// <summary>
	/// tb_供应商信息:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tb_供应商信息
	{
		public tb_供应商信息()
		{}
		#region Model
		private string _id;
		private string _供应商名称;
		private string _地址;
		private string _邮政编码;
		private string _联系电话;
		private string _传真;
		private string _开户银行;
		private string _账户;
		private string _联系人;
		private string _主要产品或服务;
		private DateTime? _评估日期;
		private string _评估结论;
		/// <summary>
		/// 
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 供应商名称
		{
			set{ _供应商名称=value;}
			get{return _供应商名称;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 地址
		{
			set{ _地址=value;}
			get{return _地址;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 邮政编码
		{
			set{ _邮政编码=value;}
			get{return _邮政编码;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 联系电话
		{
			set{ _联系电话=value;}
			get{return _联系电话;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 传真
		{
			set{ _传真=value;}
			get{return _传真;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 开户银行
		{
			set{ _开户银行=value;}
			get{return _开户银行;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 账户
		{
			set{ _账户=value;}
			get{return _账户;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 联系人
		{
			set{ _联系人=value;}
			get{return _联系人;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 主要产品或服务
		{
			set{ _主要产品或服务=value;}
			get{return _主要产品或服务;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? 评估日期
		{
			set{ _评估日期=value;}
			get{return _评估日期;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 评估结论
		{
			set{ _评估结论=value;}
			get{return _评估结论;}
		}
		#endregion Model

	}
}

