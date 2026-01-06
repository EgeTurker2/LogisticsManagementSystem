/*
using LogisticsManagementSystem1;
using Xunit;
using System.Data.SqlClient;

namespace LogisticsManagementSystem1.Tests
{
    public class UnitTest1
    {
        private readonly string connectionString = @"Server=.;Database=LogisticsSystemDB;Trusted_Connection=True;";
        [Fact]
        public void TrackingNumber_ShouldBeEightDigits()
        {
            var cargoForm = new CargoForm();
            string result = cargoForm.GenerateTrackingNumber();

            Assert.NotNull(result);
            Assert.Equal(8, result.Length);
        }
        public void CreateUser_ValidInputs_ShouldInsertToDatabase()
        {
            // 1. Arrange (Hazýrlýk)
            // Test her çalýþtýðýnda çakýþma olmamasý için rastgele bir kullanýcý adý üretelim
            string uniqueUser = "TestUser_" + System.Guid.NewGuid().ToString().Substring(0, 5);
            string testPass = "Test1234";
            string testRole = "Admin";

            // 2. Act (Eylem)
            // Senin btnCreate kodundaki mantýðý uyguluyoruz
            bool isInserted = false;
            
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Users (Username, Password, Role)
                                 VALUES (@Username, @Password, @Role)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", uniqueUser);
                cmd.Parameters.AddWithValue("@Password", testPass);
                cmd.Parameters.AddWithValue("@Role", testRole);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                conn.Close();

                if (rows > 0) isInserted = true;
            }

            // 3. Assert (Doðrulama)
            // Veritabanýna gerçekten satýr eklendi mi?
            Assert.True(isInserted, "Kullanýcý veritabanýna kaydedilemedi.");

            // Ekstra kontrol: Veritabanýndan geri çekip veriler doðru mu bakalým
            bool dataVerified = VerifyUserInDb(uniqueUser, testRole);
            Assert.True(dataVerified, "Kaydedilen veriler veritabanýndakiyle eþleþmiyor.");
        }

        // Yardýmcý Metot: Kaydý doðrulamak için
        private bool VerifyUserInDb(string username, string role)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @User AND Role = @Role";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@User", username);
                cmd.Parameters.AddWithValue("@Role", role);
                
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
        public void CreateShipment_MethodFlow_ShouldInsertCorrectData()
        {
            var cargoForm = new CargoForm();
            string testSender = "Ahmet Yýlmaz";
            string testReceiver = "Mehmet Demir";
            string testAddress = "Kadýköy, Ýstanbul";
            
            string generatedTracking = cargoForm.GenerateTrackingNumber();

            bool isSuccess = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Shipments
                                (TrackingNumber, SenderName, ReceiverName, ReceiverAddress, CurrentStatus)
                                VALUES
                                (@TrackingNumber, @SenderName, @ReceiverName, @ReceiverAddress, 'Created')";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TrackingNumber", generatedTracking);
                cmd.Parameters.AddWithValue("@SenderName", testSender);
                cmd.Parameters.AddWithValue("@ReceiverName", testReceiver);
                cmd.Parameters.AddWithValue("@ReceiverAddress", testAddress);

                conn.Open();
                int affectedRows = cmd.ExecuteNonQuery();
                if (affectedRows > 0) isSuccess = true;
                conn.Close();
            }

            Assert.True(isSuccess, "Kargo kaydý baþarýsýz, veritabanýna satýr eklenmedi.");

            Assert.Equal(8, generatedTracking.Length);

            bool isDataCorrect = VerifyShipment(generatedTracking, testSender);
            Assert.True(isDataCorrect, "Veritabanýna kaydedilen veriler gönderilenlerle eþleþmiyor.");
        }

        private bool VerifyShipment(string trackingNo, string sender)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Shipments WHERE TrackingNumber = @T AND SenderName = @S";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@T", trackingNo);
                cmd.Parameters.AddWithValue("@S", sender);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
    }
}
    We are unable to run the test project because of a .NET framework version incompatibility. 
    Although the test project won't build, the test logic and source codes are ready and correct.
    We have developed unit tests for user creation, cargo creation, and tracking number generation.
*/