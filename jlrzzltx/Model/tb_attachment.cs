using System;
namespace gzpi.Model
{
	/// <summary>
	/// tb_attachment:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tb_attachment
	{
		public tb_attachment()
		{}
		#region Model
		private Guid _f_id;
		private string _f_filename;
		private DateTime? _f_createtime;
		private string _f_fliesize;
		private string _f_creator;
		private string _f_filetype;
		private string _f_filepath;
		/// <summary>
		/// 
		/// </summary>
		public Guid f_id
		{
			set{ _f_id=value;}
			get{return _f_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string f_FileName
		{
			set{ _f_filename=value;}
			get{return _f_filename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? f_CreateTime
		{
			set{ _f_createtime=value;}
			get{return _f_createtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string f_FlieSize
		{
			set{ _f_fliesize=value;}
			get{return _f_fliesize;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string f_Creator
		{
			set{ _f_creator=value;}
			get{return _f_creator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string f_FileType
		{
			set{ _f_filetype=value;}
			get{return _f_filetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string f_FilePath
		{
			set{ _f_filepath=value;}
			get{return _f_filepath;}
		}
		#endregion Model

	}
}

