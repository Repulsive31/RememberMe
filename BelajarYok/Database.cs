using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BelajarYok.Model;
using SQLite;
namespace BelajarYok
{
    public class Database
    {
        public readonly SQLiteAsyncConnection db;
        public Database(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<User>();
            db.CreateTableAsync<Event>();
            db.CreateTableAsync<ToDoListHeader>();
            db.CreateTableAsync<Group>();
        }
        public async Task CreateUser(SQLiteAsyncConnection conn, User user)
        {
            await SQLiteNetExtensionsAsync.Extensions.WriteOperations.InsertWithChildrenAsync(conn, user);
        }
        public async Task<List<User>> GetUser()
        {
            var x = await SQLiteNetExtensionsAsync.Extensions.ReadOperations.GetAllWithChildrenAsync<User>(db);
            return x;
        }
        public async Task CreateEvent(SQLiteAsyncConnection conn, Event @event)
        {
            await SQLiteNetExtensionsAsync.Extensions.WriteOperations.InsertWithChildrenAsync(conn, @event);
        }
        public async Task<List<Event>> GetEvent()
        {
            var x = await SQLiteNetExtensionsAsync.Extensions.ReadOperations.GetAllWithChildrenAsync<Event>(db);
            return x;
        }
        public async Task CreateToDoListHeader(SQLiteAsyncConnection conn, ToDoListHeader toDoHeader)
        {
            await SQLiteNetExtensionsAsync.Extensions.WriteOperations.InsertWithChildrenAsync(conn, toDoHeader);
        }
        public async Task<List<ToDoListHeader>> GetToDoListHeader()
        {
            var x = await SQLiteNetExtensionsAsync.Extensions.ReadOperations.GetAllWithChildrenAsync<ToDoListHeader>(db);
            return x;
        }
        public async Task CreateGroup(SQLiteAsyncConnection conn, Group group)
        {
            await SQLiteNetExtensionsAsync.Extensions.WriteOperations.InsertWithChildrenAsync(conn, group);
        }
        public async Task<List<Group>> GetGroup()
        {
            var x = await SQLiteNetExtensionsAsync.Extensions.ReadOperations.GetAllWithChildrenAsync<Group>(db);
            return x;
        }
    }
}
