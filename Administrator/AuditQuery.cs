using Administrator;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Administrator
{
    public class AuditQuery
{
    private static AuditQuery _instance;
    public static AuditQuery Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new AuditQuery();
            }
            return _instance;
        }
    }

    private int _id;

    public int getId
    {
        get { return _id; }
        set { _id = value; }
    }
    // id, user_id, action, date
    public void UpdateAudit(string word)
    {
        var query = WatchupongConnections.Instance.CreateCommand
            ("BEGIN \n" +
            "   BEGIN TRANSACTION \n" +
            "       DECLARE @id AS INT\n" +
            "       SET @id = (SELECT COUNT(Audit_id) FROM Audit) + 1 " +
            "       INSERT INTO Audit VALUES(@id, @usid, CONCAT('UPDATE ', @word), @date) \n" +
            "   COMMIT\n" +
            "END");
        query.Parameters.AddWithValue("@usid", _id);
        query.Parameters.AddWithValue("@date", DateTime.Now);
        query.Parameters.AddWithValue("@word", word);
        query.ExecuteNonQuery();
    }
    public void DeleteAudit(string word)
    {
        var query = WatchupongConnections.Instance.CreateCommand
            ("BEGIN \n" +
            "   BEGIN TRANSACTION \n" +
            "       DECLARE @id AS INT\n" +
            "       SET @id = (SELECT COUNT(Audit_id) FROM Audit) + 1 " +
            "       INSERT INTO Audit VALUES(@id, @usid, CONCAT('DELETE ', @word), @date) \n" +
            "   COMMIT\n" +
            "END");
        query.Parameters.AddWithValue("@usid", _id);
        query.Parameters.AddWithValue("@date", DateTime.Now);
        query.Parameters.AddWithValue("@word", word);
        query.ExecuteNonQuery();
    }
    public void InsertAudit(string word)
    {
        var query = WatchupongConnections.Instance.CreateCommand
            ("BEGIN \n" +
            "   BEGIN TRANSACTION \n" +
            "       DECLARE @id AS INT\n" +
            "       SET @id = (SELECT COUNT(Audit_id) FROM Audit) + 1 " +
            "       INSERT INTO Audit VALUES(@id, @usid, CONCAT('INSERT ', @word), @date) \n" +
            "   COMMIT\n" +
            "END");
        query.Parameters.AddWithValue("@usid", _id);
        query.Parameters.AddWithValue("@date", DateTime.Now);
        query.Parameters.AddWithValue("@word", word);
        query.ExecuteNonQuery();
    }
    public void ShowAudit(DataGridView data)
        {
            var adapter = WatchupongConnections.Instance.ExecuteAdapter
                ("Select audit_id,  u.name, actions, created_at From Audit as a \n" +
                "INNER JOIN Account as u on u.user_id = a.user_id");
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            data.DataSource= dataTable;


        }
    }
}
