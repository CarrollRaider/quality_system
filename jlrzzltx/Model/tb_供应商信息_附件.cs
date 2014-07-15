using System;
namespace gzpi.Model
{
	/// <summary>
	/// tb_供应商信息_附件:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tb_供应商信息_附件
	{
		public tb_供应商信息_附件()
		{}
		#region Model
		private Guid _id;
		private Guid _sid;
		private string _文件名;
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
		public Guid SID
		{
			set{ _sid=value;}
			get{return _sid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 文件名
		{
			set{ _文件名=value;}
			get{return _文件名;}
		}
		#endregion Model

	}
}

