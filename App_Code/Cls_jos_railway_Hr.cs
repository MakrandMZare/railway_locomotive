using System;
using System.Data;
using System.Configuration;
//using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
//using System.Xml.Linq;
using System.Data.SqlClient;
namespace Railway
{
    public class Cls_jos_railway_Hr : Cls_DBConnection
    {
       
        public string Hrid;
        public string surname;
        public string fname;
        public string FullName;
        public string SalaryCode;
        public string equa;
        public string tech_qua;
        public string m_cat;
        public string EmployeeNo;
        public string BloodGroup;
        public string Section;
        public string Pan;
        public string Post;
        public string Gender;
        public string Cast;
        public string SubCast;
        public string DOB;
        public string RetirementDate;
        public string paddress;
        public string Address;
        public string RecidentNo;
        public string MobileNo;
        public string EmailAddress;
        public string State;
        public string City;
        public string Disease;
        public string photo;
        public string signature;
        public string thumb;
        public Cls_jos_railway_Hr()
        {
            //Declare Connection
            //cnn = new SqlConnection(@"SERVER=railwayd.db.4989407.hostedresource.com;DATABASE=railwayd;USER ID=railwayd;PASSWORD=Dhara1980 SERVER=railwayd.db.4989407.hostedresource.com;DATABASE=railwayd;USER ID=railwayd;PASSWORD=Dhara1980");

        }
        public Int64 Insert_Data()
        {
            Int64 n = 0;
            try
            {
                cmd = new SqlCommand("SELECT COUNT(*) FROM jos_railway_Hr", cnn);
                cmd.Connection.Open();
                n = Convert.ToInt64(cmd.ExecuteScalar());
                cmd.Connection.Close();
                
                
                
                
                        //cmd = new SqlCommand("INSERT INTO jos_railway_Hr(surname,fname,FullName,SalaryCode,equa,tech_qua,m_cat,EmployeeNo,BloodGroup,Section,Pan,Post,Gender,Cast,SubCast,DOB,RetirementDate,paddress,Address,RecidentNo,MobileNo,EmailAddress,State,City,Disease,photo,signature,thumb) VALUES (@surname,@fname,@FullName,@SalaryCode,@equa,@tech_qua,@m_cat,@EmployeeNo,@BloodGroup,@Section,@Pan,@Post,@Gender,@Cast,@SubCast,@DOB,@RetirementDate,@paddress,@Address,@RecidentNo,@MobileNo,@EmailAddress,@State,@City,@Disease,@photo,@signature,@thumb)", cnn);
                cmd = new SqlCommand("INSERT INTO jos_railway_Hr(surname,fullname,father_name,salarycode,equa,tech_qua,m_cat,EmployeeNo,BloodGroup,Section,PAN,Post,Gender,Caste,SubCaste,DOB,RetirementDate,paddress,Address,ResidentNo,MobileNo,EmailAddress,State,City,Disease,photo,signature,thumb)VALUES(@surname,@fullname,@father_name,@salarycode,@equa,@tech_qua,@m_cat,@EmployeeNo,@BloodGroup,@Section,@PAN,@Post,@Gender,@Caste,@SubCaste,@DOB,@RetirementDate,@paddress,@Address,@ResidentNo,@MobileNo,@EmailAddress,@State,@City,@Disease,@photo,@signature,@thumb)", cnn);
      cmd.Parameters.AddWithValue("@surname",this.surname);
      cmd.Parameters.AddWithValue("@fullname",this.FullName);
      cmd.Parameters.AddWithValue("@father_name",this.fname);
      cmd.Parameters.AddWithValue("@salarycode",this.SalaryCode); 
      cmd.Parameters.AddWithValue("@equa",this.equa); 
      cmd.Parameters.AddWithValue("@tech_qua",this.tech_qua); 
      cmd.Parameters.AddWithValue("@m_cat",this.m_cat); 
      cmd.Parameters.AddWithValue("@EmployeeNo",this.EmployeeNo); 
      cmd.Parameters.AddWithValue("@BloodGroup",this.BloodGroup); 
      cmd.Parameters.AddWithValue("@Section",this.Section); 
      cmd.Parameters.AddWithValue("@PAN",this.Pan); 
      cmd.Parameters.AddWithValue("@Post",this.Post); 
      cmd.Parameters.AddWithValue("@Gender",this.Gender); 
      cmd.Parameters.AddWithValue("@Caste",this.Cast); 
      cmd.Parameters.AddWithValue("@SubCaste",this.SubCast); 
      //cmd.Parameters.AddWithValue("@DOB",Convert.ToDateTime(this.DOB)); 
      cmd.Parameters.AddWithValue("@DOB",this.DOB); 
      cmd.Parameters.AddWithValue("@RetirementDate",this.RetirementDate); 
      cmd.Parameters.AddWithValue("@paddress",this.paddress); 
      cmd.Parameters.AddWithValue("@Address",this.Address); 
      cmd.Parameters.AddWithValue("@ResidentNo",this.RecidentNo); 
      cmd.Parameters.AddWithValue("@MobileNo",this.MobileNo); 
      cmd.Parameters.AddWithValue("@EmailAddress",this.EmailAddress); 
      cmd.Parameters.AddWithValue("@State",this.State); 
      cmd.Parameters.AddWithValue("@City",this.City);
      cmd.Parameters.AddWithValue("@Disease",this.Disease);
      cmd.Parameters.AddWithValue("@photo",this.photo);
      cmd.Parameters.AddWithValue("@signature",this.signature);
      cmd.Parameters.AddWithValue("@thumb", this.thumb);
                cmd.Connection.Open();
                int m = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                if (n > 0)
                {
                    cmd = new SqlCommand("SELECT MAX(id_Hr) FROM jos_railway_Hr", cnn);
                    cmd.Connection.Open();
                    n = Convert.ToInt64(cmd.ExecuteScalar());
                    //n++;
                    cmd.Connection.Close();
                }
                else { n = 1; }
                if (m == 1)
                {
                    return n;
                }
                else
                {
                    return 0;
                }
            }
            catch { throw; }
        }
        //Delete Data
        public int Delete_Data()
        {
            try
            {
                cmd = new SqlCommand("DELETE FROM jos_railway_Hr  WHERE (Hrid=@Hrid)", cnn);
                cmd.Parameters.AddWithValue("@Hrid", this.Hrid);
                cmd.Connection.Open();
                int n = Convert.ToInt16(cmd.ExecuteNonQuery());
                cmd.Connection.Close();
                return n;
            }
            catch { throw; }
        }
        public int Update_Data()
        {
            try
            {
                //cmd = new SqlCommand(" UPDATE jos_railway_Hr SET surname=@surname,fname=@fname,FullName=@FullName,SalaryCode=@SalaryCode,equa=@equa,tech_qua=@tech_qua,m_cat=@m_cat,EmployeeNo=@EmployeeNo,BloodGroup=@BloodGroup,Section=@Section,Pan=@Pan,Post=@Post,Gender=@Gender,Cast=@Cast,SubCast=@SubCast,DOB=@DOB,RetirementDate=@RetirementDate,paddress=@paddress,Address=@Address,RecidentNo=@RecidentNo,MobileNo=@MobileNo,EmailAddress=@EmailAddress,State=@State,City=@City,Disease=@Disease,photo=@photo,signature=@signature,thumb=@thumb WHERE Hrid=@Hrid ", cnn);
                cmd = new SqlCommand("UPDATE jos_railway_Hr SET surname = @surname,fullname = @fullname,father_name=@father_name,salarycode = @salarycode," +
" equa = @equa,tech_qua = @tech_qua,m_cat = @m_cat,EmployeeNo = @EmployeeNo,BloodGroup = @BloodGroup,Section = @Section,PAN = @PAN,Post = @Post,Gender = @Gender,Caste = @Caste," +
" SubCaste = @SubCaste,DOB = @DOB,RetirementDate = @RetirementDate,paddress = @paddress," +
" Address = @Address,ResidentNo = @ResidentNo,MobileNo = @MobileNo,EmailAddress = @EmailAddress,State = @State,City = @City,Disease = @Disease,photo = @photo,signature = @signature,thumb = @thumb WHERE id_Hr = @id_Hr", cnn);
                cmd.Parameters.AddWithValue("@surname", this.surname);
                cmd.Parameters.AddWithValue("@fullname", this.FullName);
                cmd.Parameters.AddWithValue("@father_name", this.fname);
                cmd.Parameters.AddWithValue("@salarycode", this.SalaryCode);
                cmd.Parameters.AddWithValue("@equa", this.equa);
                cmd.Parameters.AddWithValue("@tech_qua", this.tech_qua);
                cmd.Parameters.AddWithValue("@m_cat", this.m_cat);
                cmd.Parameters.AddWithValue("@EmployeeNo", this.EmployeeNo);
                cmd.Parameters.AddWithValue("@BloodGroup", this.BloodGroup);
                cmd.Parameters.AddWithValue("@Section", this.Section);
                cmd.Parameters.AddWithValue("@PAN", this.Pan);
                cmd.Parameters.AddWithValue("@Post", this.Post);
                cmd.Parameters.AddWithValue("@Gender", this.Gender);
                cmd.Parameters.AddWithValue("@Caste", this.Cast);
                cmd.Parameters.AddWithValue("@SubCaste", this.SubCast);
                cmd.Parameters.AddWithValue("@DOB", this.DOB);
                cmd.Parameters.AddWithValue("@RetirementDate", this.RetirementDate);
                cmd.Parameters.AddWithValue("@paddress", this.paddress);
                cmd.Parameters.AddWithValue("@Address", this.Address);
                cmd.Parameters.AddWithValue("@ResidentNo", this.RecidentNo);
                cmd.Parameters.AddWithValue("@MobileNo", this.MobileNo);
                cmd.Parameters.AddWithValue("@EmailAddress", this.EmailAddress);
                cmd.Parameters.AddWithValue("@State", this.State);
                cmd.Parameters.AddWithValue("@City", this.City);
                cmd.Parameters.AddWithValue("@Disease", this.Disease);
                cmd.Parameters.AddWithValue("@photo", this.photo);
                cmd.Parameters.AddWithValue("@signature", this.signature);
                cmd.Parameters.AddWithValue("@thumb", this.thumb);
                cmd.Parameters.AddWithValue("@id_Hr", this.Hrid);
                cmd.Connection.Open();
                int n = Convert.ToInt16(cmd.ExecuteNonQuery());
                cmd.Connection.Close();
                return n;
            }
            catch { throw; }
        }
        public DataTable Select_Fullname()
        {
            cmd = new SqlCommand("SELECT id_hr as id,(jos_railway_Hr.surname + ' ' + jos_railway_Hr.fullname + ' ' +jos_railway_Hr.father_name) as sname FROM jos_railway_Hr", cnn);
            da = new SqlDataAdapter();
            dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        public DataTable Select_Data()
        {
        cmd = new SqlCommand("SELECT " +
  "jos_railway_Hr.id_hr  AS \"id\" "+ 
  ",jos_railway_Hr.surname   as  \"Surname\"" +  
  ",jos_railway_Hr.fullName   as  \"Name\" "+  
  ",jos_railway_Hr.father_name   as  \"Father's Name\"  "+
  ",jos_railway_Hr.SalaryCode  as  \"Salary Code\""+ 
  ",jos_railway_Hr.equa   as  \"Educatinal Qualification\""+ 
  ",jos_railway_Hr.tech_qua   as  \"Technical Qualification\""+
  ",jos_railway_Hr.EmployeeNo   as  \"Employee No\" "+
  ",jos_railway_Hr.BloodGroup  as  \"Blood Group\""+ 
  ",jos_railway_Hr.Pan   as  \"PAN\""+ 
  ",jos_railway_Hr.Gender   as  \"Gender\"" +
  ",jos_railway_Hr.DOB   as  \"DOB\" "+
  ",jos_railway_Hr.RetirementDate   as  \"Retirement Date\" "+
  ",jos_railway_Hr.paddress   as  \"Permanent Address\" "+
  ",jos_railway_Hr.Address   as  \"Current Address\" "+
  ",jos_railway_Hr.ResidentNo   as  \"Recident No\""+
  ",jos_railway_Hr.MobileNo   as  \"Mobile No\" "+
  ",jos_railway_Hr.EmailAddress   as  \"Email Address\""+  
  ",jos_railway_Hr.State   as  \"State\" "+
  ",jos_railway_Hr.City   as  \"City\""+ 
  ",jos_railway_mst_medical.name  AS  \"Medical Category\""+ 
  ",jos_railway_section.s_type  as  \"Section\""+ 
  ",jos_railway_mst_caste.caste  as  \"Caste\"  "+
  ",jos_railway_mst_sub_caste.sub_caste  as  \"Sub Caste\""+  
  ",jos_railway_Hr.Post   as  \"Post\""+ 
  ",jos_railway_Hr.photo  as  \"Photo\" "+
  ",jos_railway_Hr.signature  as  \"Signature\" "+ 
  ",jos_railway_Hr.thumb  as  \"Thumb\" "+
  ",jos_railway_Hr.Disease as \"Serious Diesease\""+
  " FROM  jos_railway_Hr  "+
  "LEFT OUTER JOIN  jos_railway_mst_medical  ON  jos_railway_mst_medical.\"id_med\"  =  jos_railway_Hr.m_cat "+
  "LEFT OUTER JOIN  jos_railway_section  ON  jos_railway_section .id_section  =  jos_railway_Hr.\"section\" "+
  "LEFT OUTER JOIN  jos_railway_mst_caste  ON  jos_railway_mst_caste.id_caste  =  jos_railway_Hr .\"caste\""+  
  "LEFT OUTER JOIN  jos_railway_mst_sub_caste  ON  jos_railway_mst_sub_caste.id_s_caste  =  jos_railway_Hr.SubCaste",cnn);
            
            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        public DataTable Select_DataById()
        {
            cmd = new SqlCommand("SELECT " +
      "jos_railway_Hr.id_hr  AS \"id\" " +
      ",jos_railway_Hr.surname   as  \"Surname\"" +
      ",jos_railway_Hr.fullName   as  \"sName\" " +
      ",jos_railway_Hr.father_name   as  \"FathersName\"  " +
      ",jos_railway_Hr.SalaryCode  as  \"Salary Code\"" +
      ",jos_railway_Hr.equa   as  \"Educatinal Qualification\"" +
      ",jos_railway_Hr.tech_qua   as  \"Technical Qualification\"" +
      ",jos_railway_Hr.EmployeeNo   as  \"Employee No\" " +
      ",jos_railway_Hr.BloodGroup  as  \"BloodGroup\"" +
      ",jos_railway_Hr.Pan   as  \"PAN\"" +
      ",jos_railway_Hr.Gender   as  \"Gender\"" +
      ",CONVERT(VARCHAR(10),jos_railway_Hr.DOB,5)   as  \"DOB\" " +
      ",CONVERT(VARCHAR(10),jos_railway_Hr.RetirementDate,5)   as  \"Retirement Date\" " +
      ",jos_railway_Hr.paddress   as  \"Permanent Address\" " +
      ",jos_railway_Hr.Address   as  \"Current Address\" " +
      ",jos_railway_Hr.ResidentNo   as  \"Recident No\"" +
      ",jos_railway_Hr.MobileNo   as  \"Mobile No\" " +
      ",jos_railway_Hr.EmailAddress   as  \"Email Address\"" +
      ",jos_railway_Hr.State   as  \"State\" " +
      ",jos_railway_Hr.City   as  \"City\"" +
      ",jos_railway_mst_medical.name  AS  \"MedicalCategory\"" +
      ",jos_railway_section.s_type  as  \"Section\"" +
      ",jos_railway_mst_caste.caste  as  \"Caste\"  " +
      ",jos_railway_mst_sub_caste.sub_caste  as  \"Sub Caste\"" +
      ",jos_railway_Hr.Post   as  \"Post\"" +
      ",jos_railway_Hr.photo  as  \"Photo\" " +
      ",jos_railway_Hr.signature  as  \"Signature\" " +
      ",jos_railway_Hr.thumb  as  \"Thumb\" " +
      ",jos_railway_Hr.Disease as \"SeriousDiesease\"" +
      " FROM  jos_railway_Hr  " +
      "INNER JOIN   jos_railway_mst_medical  ON  jos_railway_mst_medical.\"id_med\"  =  jos_railway_Hr.m_cat " +
      "INNER JOIN  jos_railway_section  ON  jos_railway_section .id_section  =  jos_railway_Hr.\"section\" " +
      "INNER JOIN jos_railway_mst_caste  ON  jos_railway_mst_caste.id_caste  =  jos_railway_Hr .\"caste\"" +
      "INNER JOIN  jos_railway_mst_sub_caste  ON  jos_railway_mst_sub_caste.id_s_caste  =  jos_railway_Hr.SubCaste " +
      "WHERE  jos_railway_Hr.id_hr='" + this.Hrid + "'", cnn);

            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        public DataTable Get_EmployeeList()
        {
            cmd = new SqlCommand("SELECT  " +
                                 "jos_railway_Hr.id_hr  AS \"id\"  " +
                                 ",(jos_railway_Hr.surname + ' ' + jos_railway_Hr.fullName + ' ' + jos_railway_Hr.father_name)   as  \"Sname\" " +
                                 ",jos_railway_section.s_type  as \"Section\" " +
                                 "FROM jos_railway_Hr " +
                                 "INNER JOin jos_railway_section ON jos_railway_section.id_section = jos_railway_Hr.Section " +
                                 "order by jos_railway_Hr.Section " , cnn);
            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            return dt;

        }                   
    }
}
