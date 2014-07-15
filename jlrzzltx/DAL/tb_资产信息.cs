using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace gzpi.DAL
{
	/// <summary>
	/// 数据访问类:tb_资产信息
	/// </summary>
	public partial class tb_资产信息
	{
		public tb_资产信息()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(gzpi.Model.tb_资产信息 model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tb_资产信息(");
			strSql.Append("ID,固定资产编号,固定资产名称,规格型号,使用部门,存放地点,使用状况,开始使用日期,原值,发票号,出厂号,制造商,销货单位,折旧及报废情况)");
			strSql.Append(" values (");
			strSql.Append("@ID,@固定资产编号,@固定资产名称,@规格型号,@使用部门,@存放地点,@使用状况,@开始使用日期,@原值,@发票号,@出厂号,@制造商,@销货单位,@折旧及报废情况)");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@固定资产编号", SqlDbType.NChar,10),
					new SqlParameter("@固定资产名称", SqlDbType.NChar,10),
					new SqlParameter("@规格型号", SqlDbType.NChar,10),
					new SqlParameter("@使用部门", SqlDbType.NChar,10),
					new SqlParameter("@存放地点", SqlDbType.NChar,10),
					new SqlParameter("@使用状况", SqlDbType.NChar,10),
					new SqlParameter("@开始使用日期", SqlDbType.NChar,10),
					new SqlParameter("@原值", SqlDbType.NChar,10),
					new SqlParameter("@发票号", SqlDbType.NChar,10),
					new SqlParameter("@出厂号", SqlDbType.NChar,10),
					new SqlParameter("@制造商", SqlDbType.NChar,10),
					new SqlParameter("@销货单位", SqlDbType.NChar,10),
					new SqlParameter("@折旧及报废情况", SqlDbType.NChar,10)};
			parameters[0].Value = Guid.NewGuid();
			parameters[1].Value = model.固定资产编号;
			parameters[2].Value = model.固定资产名称;
			parameters[3].Value = model.规格型号;
			parameters[4].Value = model.使用部门;
			parameters[5].Value = model.存放地点;
			parameters[6].Value = model.使用状况;
			parameters[7].Value = model.开始使用日期;
			parameters[8].Value = model.原值;
			parameters[9].Value = model.发票号;
			parameters[10].Value = model.出厂号;
			parameters[11].Value = model.制造商;
			parameters[12].Value = model.销货单位;
			parameters[13].Value = model.折旧及报废情况;

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
		public bool Update(gzpi.Model.tb_资产信息 model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tb_资产信息 set ");
			strSql.Append("ID=@ID,");
			strSql.Append("固定资产编号=@固定资产编号,");
			strSql.Append("固定资产名称=@固定资产名称,");
			strSql.Append("规格型号=@规格型号,");
			strSql.Append("使用部门=@使用部门,");
			strSql.Append("存放地点=@存放地点,");
			strSql.Append("使用状况=@使用状况,");
			strSql.Append("开始使用日期=@开始使用日期,");
			strSql.Append("原值=@原值,");
			strSql.Append("发票号=@发票号,");
			strSql.Append("出厂号=@出厂号,");
			strSql.Append("制造商=@制造商,");
			strSql.Append("销货单位=@销货单位,");
			strSql.Append("折旧及报废情况=@折旧及报废情况");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@固定资产编号", SqlDbType.NChar,10),
					new SqlParameter("@固定资产名称", SqlDbType.NChar,10),
					new SqlParameter("@规格型号", SqlDbType.NChar,10),
					new SqlParameter("@使用部门", SqlDbType.NChar,10),
					new SqlParameter("@存放地点", SqlDbType.NChar,10),
					new SqlParameter("@使用状况", SqlDbType.NChar,10),
					new SqlParameter("@开始使用日期", SqlDbType.NChar,10),
					new SqlParameter("@原值", SqlDbType.NChar,10),
					new SqlParameter("@发票号", SqlDbType.NChar,10),
					new SqlParameter("@出厂号", SqlDbType.NChar,10),
					new SqlParameter("@制造商", SqlDbType.NChar,10),
					new SqlParameter("@销货单位", SqlDbType.NChar,10),
					new SqlParameter("@折旧及报废情况", SqlDbType.NChar,10)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.固定资产编号;
			parameters[2].Value = model.固定资产名称;
			parameters[3].Value = model.规格型号;
			parameters[4].Value = model.使用部门;
			parameters[5].Value = model.存放地点;
			parameters[6].Value = model.使用状况;
			parameters[7].Value = model.开始使用日期;
			parameters[8].Value = model.原值;
			parameters[9].Value = model.发票号;
			parameters[10].Value = model.出厂号;
			parameters[11].Value = model.制造商;
			parameters[12].Value = model.销货单位;
			parameters[13].Value = model.折旧及报废情况;

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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_资产信息 ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

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
		/// 得到一个对象实体
		/// </summary>
		public gzpi.Model.tb_资产信息 GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,固定资产编号,固定资产名称,规格型号,使用部门,存放地点,使用状况,开始使用日期,原值,发票号,出厂号,制造商,销货单位,折旧及报废情况 from tb_资产信息 ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			gzpi.Model.tb_资产信息 model=new gzpi.Model.tb_资产信息();
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
		public gzpi.Model.tb_资产信息 DataRowToModel(DataRow row)
		{
			gzpi.Model.tb_资产信息 model=new gzpi.Model.tb_资产信息();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID= new Guid(row["ID"].ToString());
				}
				if(row["固定资产编号"]!=null)
				{
					model.固定资产编号=row["固定资产编号"].ToString();
				}
				if(row["固定资产名称"]!=null)
				{
					model.固定资产名称=row["固定资产名称"].ToString();
				}
				if(row["规格型号"]!=null)
				{
					model.规格型号=row["规格型号"].ToString();
				}
				if(row["使用部门"]!=null)
				{
					model.使用部门=row["使用部门"].ToString();
				}
				if(row["存放地点"]!=null)
				{
					model.存放地点=row["存放地点"].ToString();
				}
				if(row["使用状况"]!=null)
				{
					model.使用状况=row["使用状况"].ToString();
				}
				if(row["开始使用日期"]!=null)
				{
					model.开始使用日期=row["开始使用日期"].ToString();
				}
				if(row["原值"]!=null)
				{
					model.原值=row["原值"].ToString();
				}
				if(row["发票号"]!=null)
				{
					model.发票号=row["发票号"].ToString();
				}
				if(row["出厂号"]!=null)
				{
					model.出厂号=row["出厂号"].ToString();
				}
				if(row["制造商"]!=null)
				{
					model.制造商=row["制造商"].ToString();
				}
				if(row["销货单位"]!=null)
				{
					model.销货单位=row["销货单位"].ToString();
				}
				if(row["折旧及报废情况"]!=null)
				{
					model.折旧及报废情况=row["折旧及报废情况"].ToString();
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
			strSql.Append("select ID,固定资产编号,固定资产名称,规格型号,使用部门,存放地点,使用状况,开始使用日期,原值,发票号,出厂号,制造商,销货单位,折旧及报废情况 ");
			strSql.Append(" FROM tb_资产信息 ");
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
			strSql.Append(" ID,固定资产编号,固定资产名称,规格型号,使用部门,存放地点,使用状况,开始使用日期,原值,发票号,出厂号,制造商,销货单位,折旧及报废情况 ");
			strSql.Append(" FROM tb_资产信息 ");
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
			strSql.Append("select count(1) FROM tb_资产信息 ");
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
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from tb_资产信息 T ");
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
			parameters[0].Value = "tb_资产信息";
			parameters[1].Value = "ID";
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

