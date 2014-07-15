using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using gzpi.Model;
namespace gzpi.BLL
{
	/// <summary>
	/// tb_attachment
	/// </summary>
	public partial class tb_attachment
	{
		private readonly gzpi.DAL.tb_attachment dal=new gzpi.DAL.tb_attachment();
		public tb_attachment()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(Guid f_id)
		{
			return dal.Exists(f_id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(gzpi.Model.tb_attachment model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(gzpi.Model.tb_attachment model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(Guid f_id)
		{
			
			return dal.Delete(f_id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string f_idlist )
		{
			return dal.DeleteList(Maticsoft.Common.PageValidate.SafeLongFilter(f_idlist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public gzpi.Model.tb_attachment GetModel(Guid f_id)
		{
			
			return dal.GetModel(f_id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public gzpi.Model.tb_attachment GetModelByCache(Guid f_id)
		{
			
			string CacheKey = "tb_attachmentModel-" + f_id;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(f_id);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (gzpi.Model.tb_attachment)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<gzpi.Model.tb_attachment> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<gzpi.Model.tb_attachment> DataTableToList(DataTable dt)
		{
			List<gzpi.Model.tb_attachment> modelList = new List<gzpi.Model.tb_attachment>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				gzpi.Model.tb_attachment model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

