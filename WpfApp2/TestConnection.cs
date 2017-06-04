using System.Text;
using System.Data.Entity;
using Npgsql;               // 参照を追加。

using EntityFrameWorkTest1.Model;

namespace EntityFrameWorkTest1.DB
{
    public class TestConnection : DbContext // DbContextを継承。
    {
        #region 接続プロパティ

        /// <summary>
        /// テーブル接続情報。
        /// </summary>
        public DbSet<Menu> Table { get; set; }

        #endregion

        #region コンストラクタ。

        /// <summary>
        /// コンストラクタ。
        /// </summary>
        public TestConnection()
            : base("name=ContactContext")
        {
        }
        #endregion
    }
}
