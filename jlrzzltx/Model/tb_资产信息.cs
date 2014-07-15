using System;
namespace gzpi.Model
{
	/// <summary>
	/// tb_资产信息:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tb_资产信息
	{
		public tb_资产信息()
		{}
		#region Model
		private Guid _id;
		private string _固定资产编号;
		private string _固定资产名称;
		private string _规格型号;
		private string _使用部门;
		private string _存放地点;
		private string _使用状况;
		private string _开始使用日期;
		private string _原值;
		private string _发票号;
		private string _出厂号;
		private string _制造商;
		private string _销货单位;
		private string _折旧及报废情况;
		/// <summary>
		/// 
		/// </summary>
		public Guid ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 固定资产编号
		{
			set{ _固定资产编号=value;}
			get{return _固定资产编号;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 固定资产名称
		{
			set{ _固定资产名称=value;}
			get{return _固定资产名称;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 规格型号
		{
			set{ _规格型号=value;}
			get{return _规格型号;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 使用部门
		{
			set{ _使用部门=value;}
			get{return _使用部门;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 存放地点
		{
			set{ _存放地点=value;}
			get{return _存放地点;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 使用状况
		{
			set{ _使用状况=value;}
			get{return _使用状况;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 开始使用日期
		{
			set{ _开始使用日期=value;}
			get{return _开始使用日期;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 原值
		{
			set{ _原值=value;}
			get{return _原值;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 发票号
		{
			set{ _发票号=value;}
			get{return _发票号;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 出厂号
		{
			set{ _出厂号=value;}
			get{return _出厂号;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 制造商
		{
			set{ _制造商=value;}
			get{return _制造商;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 销货单位
		{
			set{ _销货单位=value;}
			get{return _销货单位;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 折旧及报废情况
		{
			set{ _折旧及报废情况=value;}
			get{return _折旧及报废情况;}
		}
		#endregion Model

	}
}

