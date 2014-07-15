using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace gzpi.DAL
{
	/// <summary>
	/// 数据访问类:tb_attachment
	/// </summary>
	public partial class tb_attachment
	{
		public tb_attachment()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(Guid f_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tb_attachment");
			strSql.Append(" where f_id=@f_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@f_id", SqlDbType.UniqueIdentifier,16)			};
			parameters[0].Value = f_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(gzpi.Model.tb_attachment model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tb_attachment(");
			strSql.Append("f_id,f_FileName,f_CreateTime,f_FlieSize,f_Creator,f_FileType,f_FilePath)");
			strSql.Append(" values (");
			strSql.Append("@f_id,@f_FileName,@f_CreateTime,@f_FlieSize,@f_Creator,@f_FileType,@f_FilePath)");
			SqlParameter[] parameters = {
					new SqlParameter("@f_id", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@f_FileName", SqlDbType.NVarChar,100),
					new SqlParameter("@f_CreateTime", SqlDbType.DateTime),
					new SqlParameter("@f_FlieSize", SqlDbType.NVarChar,50),
					new SqlParameter("@f_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@f_FileType", SqlDbType.NVarChar,50),
					new SqlParameter("@f_FilePath", SqlDbType.NVarChar,200)};
			parameters[0].Value = Guid.NewGuid();
			parameters[1].Value = model.f_FileName;
			parameters[2].Value = model.f_CreateTime;
			parameters[3].Value = model.f_FlieSize;
			parameters[4].Value = model.f_Creator;
			parameters[5].Value = model.f_FileType;
			parameters[6].Value = model.f_FilePath;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(gzpi.Model.tb_attachment model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tb_attachment set ");
			strSql.Append("f_FileName=@f_FileName,");
			strSql.Append("f_CreateTime=@f_CreateTime,");
			strSql.Append("f_FlieSize=@f_FlieSize,");
			strSql.Append("f_Creator=@f_Creator,");
			strSql.Append("f_FileType=@f_FileType,");
			strSql.Append("f_FilePath=@f_FilePath");
			strSql.Append(" where f_id=@f_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@f_FileName", SqlDbType.NVarChar,100),
					new SqlParameter("@f_CreateTime", SqlDbType.DateTime),
					new SqlParameter("@f_FlieSize", SqlDbType.NVarChar,50),
					new SqlParameter("@f_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@f_FileType", SqlDbType.NVarChar,50),
					new SqlParameter("@f_FilePath", SqlDbType.NVarChar,200),
					new SqlParameter("@f_id", SqlDbType.UniqueIdentifier,16)};
			parameters[0].Value = model.f_FileName;
			parameters[1].Value = model.f_CreateTime;
			parameters[2].Value = model.f_FlieSize;
			parameters[3].Value = model.f_Creator;
			parameters[4].Value = model.f_FileType;
			parameters[5].Value = model.f_FilePath;
			parameters[6].Value = model.f_id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(Guid f_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_attachment ");
			strSql.Append(" where f_id=@f_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@f_id", SqlDbType.UniqueIdentifier,16)			};
			parameters[0].Value = f_id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string f_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_attachment ");
			strSql.Append(" where f_id in ("+f_idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public gzpi.Model.tb_attachment GetModel(Guid f_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 f_id,f_FileName,f_CreateTime,f_FlieSize,f_Creator,f_FileType,f_FilePath from tb_attachment ");
			strSql.Append(" where f_id=@f_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@f_id", SqlDbType.UniqueIdentifier,16)			};
			parameters[0].Value = f_id;

			gzpi.Model.tb_attachment model=new gzpi.Model.tb_attachment();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public gzpi.Model.tb_attachment DataRowToModel(DataRow row)
		{
			gzpi.Model.tb_attachment model=new gzpi.Model.tb_attachment();
			if (row != null)
			{
				if(row["f_id"]!=null && row["f_id"].ToString()!="")
				{
					model.f_id= new Guid(row["f_id"].ToString());
				}
				if(row["f_FileName"]!=null)
				{
					model.f_FileName=row["f_FileName"].ToString();
				}
				if(row["f_CreateTime"]!=null && row["f_CreateTime"].ToString()!="")
				{
					model.f_CreateTime=DateTime.Parse(row["f_CreateTime"].ToString());
				}
				if(row["f_FlieSize"]!=null)
				{
					model.f_FlieSize=row["f_FlieSize"].ToString();
				}
				if(row["f_Creator"]!=null)
				{
					model.f_Creator=row["f_Creator"].ToString();
				}
				if(row["f_FileType"]!=null)
				{
					model.f_FileType=row["f_FileType"].ToString();
				}
				if(row["f_FilePath"]!=null)
				{
					model.f_FilePath=row["f_FilePath"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select f_id,f_FileName,f_CreateTime,f_FlieSize,f_Creator,f_FileType,f_FilePath ");
			strSql.Append(" FROM tb_attachment ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" f_id,f_FileName,f_CreateTime,f_FlieSize,f_Creator,f_FileType,f_FilePath ");
			strSql.Append(" FROM tb_attachment ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM tb_attachment ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.f_id desc");
			}
			strSql.Append(")AS Row, T.*  from tb_attachment T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "tb_attachment";
			parameters[1].Value = "f_id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

