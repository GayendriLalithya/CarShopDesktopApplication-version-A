using ABCCarTraders.Healper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCarTraders.Entity
{
    public class Report
    {
        // Attributes of the Report class
        public int? reportid {  get; set; }
        public int? adminid { get; set; }
        public string reporttype { get; set; } = string.Empty;
        public DateTime createdate { get; set; }
        public string report {  get; set; } = string.Empty;

        // Default Constructor
        public Report()
        {
            // Default constructor
        }
        
        // Parameterised Constructor
        public Report(int reportid, int adminid, string reporttype, DateTime createdate, string report)
        {
            this.reportid = reportid;
            this.adminid = adminid;
            this.reporttype = reporttype;
            this.createdate = createdate;
            this.report = report;
        }

        // Behaviours and Methods
        public void GenerateReport()
        {
            string sql = "INSERT INTO Report (admin_id, report_type, create_date, report) VALUES (@AdminId, @ReportType, @CreateDate, @Report)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@AdminId", this.adminid),
                new SqlParameter("@ReportType", this.reporttype),
                new SqlParameter("@CreateDate", this.createdate),
                new SqlParameter("@Report", this.report)
            };
            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }

        public void DeleteReport()
        {
            string sql = "DELETE FROM Report WHERE report_id = @ReportId";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ReportId", this.reportid)
            };
            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }

    }
}
