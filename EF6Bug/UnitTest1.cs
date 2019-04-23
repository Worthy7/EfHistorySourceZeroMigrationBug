using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Infrastructure;
using System.Linq;

namespace EF6Bug
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSqlGenerationFrom1()
        {
            var config = new EF6Bug.Migrations.Configuration();
            var migrator = new DbMigrator(config);
            var scriptingMigrator = new MigratorScriptingDecorator(migrator);
            var migrations = migrator.GetLocalMigrations().OrderBy(c => c).ToList();
            var str = scriptingMigrator.ScriptUpdate(migrations.First(), migrations.Last());
        }

        [TestMethod]
        public void TestSqlGenerationFrom0()
        {
            var config = new EF6Bug.Migrations.Configuration();
            var migrator = new DbMigrator(config);
            var scriptingMigrator = new MigratorScriptingDecorator(migrator);
            var migrations = migrator.GetLocalMigrations().OrderBy(c => c).ToList();
            var str = scriptingMigrator.ScriptUpdate(DbMigrator.InitialDatabase, migrations.Last());
        }

    }
}
