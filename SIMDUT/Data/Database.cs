using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Linq;
using SIMDUT.Models;
using System.Threading.Tasks;
using SIMDUT.Helpers;

//https://docs.microsoft.com/en-us/xamarin/get-started/quickstarts/database?pivots=windows

namespace SIMDUT.Data
{
    public class Database
    {

        readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<ChecklistItem>().Wait();
            _database.CreateTableAsync<NoteItem>().Wait();


            //<TODO?>check if table is empty; if yes populate it with the DataItems;
            //<update> it seem that this function is called when the database need to get recreated; each new itereation of runs does not copy info but recreates it? Might have issues for 'saving' data....
            UpdateChecklistDate();

        }



        #region Notes
        public async Task<List<NoteItem>> GetNotesAsync()
        {

            return await _database.Table<NoteItem>().ToListAsync();

        }

        public async Task<NoteItem> GetNoteAsync(int id)
        {
            return await _database.Table<NoteItem>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        public async Task<int> SaveNoteAsync(NoteItem note)
        {
            if (note.ID != 0)
            {
                return await _database.UpdateAsync(note);
            }
            else
            {
                return await _database.InsertAsync(note);
            }
        }

        public async Task<int> DeleteNoteAsync(NoteItem note)
        {
            return await _database.DeleteAsync(note);
        }

        #endregion



        #region Checklist
        public Task<List<ChecklistItem>> GetChecklistAsync()
        {
            //return _database.Table<ChecklistItem>().ToListAsync();
            return _database.QueryAsync<ChecklistItem>("SELECT * FROM [ChecklistItem] ORDER BY [Section] DESC");
        }

        public Task<ChecklistItem> GetChecklistAsync(int id)
        {
            return _database.Table<ChecklistItem>().Where(i => i.ID == id).FirstOrDefaultAsync();

        }
        public Task<List<ChecklistItem>> GetChecklistNoteAsync(int id)
        {
            return _database.QueryAsync<ChecklistItem>(string.Format("SELECT [Notes] FROM [ChecklistItem] WHERE [ID] = {0} ORDER BY [Section] DESC", id));

        }
        public Task<List<ChecklistItem>> GetChecklistDateAsync(int id)
        {
            return _database.QueryAsync<ChecklistItem>(string.Format("SELECT [Date] FROM [ChecklistItem] WHERE [ID] = {0} ORDER BY [Section] DESC", id));

        }

        public Task<int> SaveChecklist(ChecklistItem di)
        {
            return _database.UpdateAsync(di);
        }

        public Task<int> InsertChecklist(ChecklistItem di)
        {
            return _database.InsertAsync(di);
        }
        #endregion
        public void UpdateChecklistDate()
        {
            if (_database.Table<ChecklistItem>().CountAsync().Result <= 0)
            {
                foreach (ChecklistItem x in ChecklistItemHelper.ChecklistItem)
                {
                    x.Date = DateTime.Now;
                    InsertChecklist(x);
                    Console.WriteLine("inserting this:" + x.Item + x.ID);
                }
            }
            else
            {
                var cl = _database.QueryAsync<ChecklistItem>(string.Format("SELECT * FROM [ChecklistItem] WHERE [IsChecked] = false"));
                foreach (ChecklistItem x in cl.Result)
                {
                    x.Date = DateTime.Now;
                    SaveChecklist(x);
                    Console.WriteLine("inserting this:" + x.Item + x.ID);
                }
            }
            Console.WriteLine("COUNT OF CHECKLISTITEMS DATABASE: " + _database.Table<ChecklistItem>().CountAsync().Result);
        }

    }
}
