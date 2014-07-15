using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace gzpi.DAL
{
	/// <summary>
	/// 数据访问类:tb_供应商信息
	/// </summary>
	public partial class tb_供应商信息
	{
		public tb_供应商信息()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tb_供应商信息");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.NChar,10)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(gzpi.Model.tb_供应商信息 model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tb_供应商信息(");
			strSql.Append("ID,供应商名称,地址,邮政编码,联系电话,传真,开户银行,账户,联系人,主要产品或服务,评估日期,评估结论)");
			strSql.Append(" values (");
			strSql.Append("@ID,@供应商名称,@地址,@邮政编码,@联系电话,@传真,@开户银行,@账户,@联系人,@主要产品或服务,@评估日期,@评估结论)");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.NChar,10),
					new SqlParameter("@供应商名称", SqlDbType.NVarChar,50),
					new SqlParameter("@地址", SqlDbType.NChar,100),
					new SqlParameter("@邮政编码", SqlDbType.NChar,10),
					new SqlParameter("@联系电话", SqlDbType.Char,20),
					new SqlParameter("@传真", SqlDbType.Char,20),
					new SqlParameter("@开户银行", SqlDbType.NVarChar,50),
					new SqlParameter("@账户", SqlDbType.NChar,30),
					new SqlParameter("@联系人", SqlDbType.NChar,20),
					new SqlParameter("@主要产品或服务", SqlDbType.NChar,100),
					new SqlParameter("@评估日期", SqlDbType.DateTime),
					new SqlParameter("@评估结论", SqlDbType.NChar,100)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.供应商名称;
			parameters[2].Value = model.地址;
			parameters[3].Value = model.邮政编码;
			parameters[4].Value = model.联系电话;
			parameters[5].Value = model.传真;
			parameters[6].Value = model.开户银行;
			parameters[7].Value = model.账户;
			parameters[8].Value = model.联系人;
			parameters[9].Value = model.主要产品或服务;
			parameters[10].Value = model.评估日期;
			parameters[11].Value = model.评估结论;

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
		public bool Update(gzpi.Model.tb_供应商信息 model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tb_供应商信息 set ");
			strSql.Append("供应商名称=@供应商名称,");
			strSql.Append("地址=@地址,");
			strSql.Append("邮政编码=@邮政编码,");
			strSql.Append("联系电话=@联系电话,");
			strSql.Append("传真=@传真,");
			strSql.Append("开户银行=@开户银行,");
			strSql.Append("账户=@账户,");
			strSql.Append("联系人=@联系人,");
			strSql.Append("主要产品或服务=@主要产品或服务,");
			strSql.Append("评估日期=@评估日期,");
			strSql.Append("评估结论=@评估结论");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@供应商名称", SqlDbType.NVarChar,50),
					new SqlParameter("@地址", SqlDbType.NChar,100),
					new SqlParameter("@邮政编码", SqlDbType.NChar,10),
					new SqlParameter("@联系电话", SqlDbType.Char,20),
					new SqlParameter("@传真", SqlDbType.Char,20),
					new SqlParameter("@开户银行", SqlDbType.NVarChar,50),
					new SqlParameter("@账户", SqlDbType.NChar,30),
					new SqlParameter("@联系人", SqlDbType.NChar,20),
					new SqlParameter("@主要产品或服务", SqlDbType.NChar,100),
					new SqlParameter("@评估日期", SqlDbType.DateTime),
					new SqlParameter("@评估结论", SqlDbType.NChar,100),
					new SqlParameter("@ID", SqlDbType.NChar,10)};
			parameters[0].Value = model.供应商名称;
			parameters[1].Value = model.地址;
			parameters[2].Value = model.邮政编码;
			parameters[3].Value = model.联系电话;
			parameters[4].Value = model.传真;
			parameters[5].Value = model.开户银行;
			parameters[6].Value = model.账户;
			parameters[7].Value = model.联系人;
			parameters[8].Value = model.主要产品或服务;
			parameters[9].Value = model.评估日期;
			parameters[10].Value = model.评估结论;
			parameters[11].Value = model.ID;

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
		public bool Delete(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_供应商信息 ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.NChar,10)			};
			parameters[0].Value = ID;

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
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_供应商信息 ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
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
		public gzpi.Model.tb_供应商信息 GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,供应商名称,地址,邮政编码,联系电话,传真,开户银行,账户,联系人,主要产品或服务,评估日期,评估结论 from tb_供应商信息 ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.NChar,10)			};
			parameters[0].Value = ID;

			gzpi.Model.tb_供应商信息 model=new gzpi.Model.tb_供应商信息();
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
		public gzpi.Model.tb_供应商信息 DataRowToModel(DataRow row)
		{
			gzpi.Model.tb_供应商信息 model=new gzpi.Model.tb_供应商信息();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["供应商名称"]!=null)
				{
					model.供应商名称=row["供应商名称"].ToString();
				}
				if(row["地址"]!=null)
				{
					model.地址=row["地址"].ToString();
				}
				if(row["邮政编码"]!=null)
				{
					model.邮政编码=row["邮政编码"].ToString();
				}
				if(row["联系电话"]!=null)
				{
					model.联系电话=row["联系电话"].ToString();
				}
				if(row["传真"]!=null)
				{
					model.传真=row["传真"].ToString();
				}
				if(row["开户银行"]!=null)
				{
					model.开户银行=row["开户银行"].ToString();
				}
				if(row["账户"]!=null)
				{
					model.账户=row["账户"].ToString();
				}
				if(row["联系人"]!=null)
				{
					model.联系人=row["联系人"].ToString();
				}
				if(row["主要产品或服务"]!=null)
				{
					model.主要产品或服务=row["主要产品或服务"].ToString();
				}
				if(row["评估日期"]!=null && row["评估日期"].ToString()!="")
				{
					model.评估日期=DateTime.Parse(row["评估日期"].ToString());
				}
				if(row["评估结论"]!=null)
				{
					model.评估结论=row["评估结论"].ToString();
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
			strSql.Append("select ID,供应商名称,地址,邮政编码,联系电话,传真,开户银行,账户,联系人,主要产品或服务,评估日期,评估结论 ");
			strSql.Append(" FROM tb_供应商信息 ");
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
			strSql.Append(" ID,供应商名称,地址,邮政编码,联系电话,传真,开户银行,账户,联系人,主要产品或服务,评估日期,评估结论 ");
			strSql.Append(" FROM tb_供应商信息 ");
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
			strSql.Append("select count(1) FROM tb_供应商信息 ");
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
			strSql.Append(")AS Row, T.*  from tb_供应商信息 T ");
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
			parameters[0].Value = "tb_供应商信息";
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

