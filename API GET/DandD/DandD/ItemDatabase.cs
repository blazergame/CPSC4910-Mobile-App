﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLitePCL;
using System.Threading.Tasks;
using DandD.Models.Game_Files;
using DandD.Models;

namespace DandD
{
    public class ItemDatabase
    {
        readonly SQLiteAsyncConnection database;
        public ItemDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Items>().Wait();
            database.CreateTableAsync<Character>().Wait();
            database.CreateTableAsync<Monster>().Wait();
            database.CreateTableAsync<apiData>().Wait();
        }

        public Task<List<Items>> RetrieveItems()
        {
            return database.Table<Items>().ToListAsync();
        }
        public Task<Items> RetrieveSpecificItem(string name)
        {
            return database.Table<Items>().Where(i => i.Name == name).FirstOrDefaultAsync();
        }
        public Task<int> InsertItem(Items item)
        {
            if (item.Name != null) //Updating Item
                return database.UpdateAsync(item);

            return database.InsertAsync(item);
        }

        public Task<int> deleteItem(Items item)
        {
            return database.DeleteAsync(item);
        }


        //********************************************CHARACTERS*************************************************************

        public Task<List<Character>> RetrieveCharacters()
        {
            return database.Table<Character>().ToListAsync();
        }
        public Task<Character> RetrieveSpecificCharacter(string name)
        {
            return database.Table<Character>().Where(i => i.Name == name).FirstOrDefaultAsync();
        }
        public Task<int> InsertCharacter(Character character)
        {
          //  if (character.Character_ID != 0) //Updating Item
             //  return database.UpdateAsync(character);
             return database.InsertAsync(character);
        }

        public Task<int> UpdateCharacter(Character character)
        {
                return database.UpdateAsync(character);
        }

        public Task<int> deleteCharacter(Character character)
        {
            return database.DeleteAsync(character);
        }


		//*****************************************MONSTER TABLES*************************************************

		public Task<List<Monster>> RetrieveMonsters()
		{
			return database.Table<Monster>().ToListAsync();
		}
		
		public Task<int> InsertMonster(Monster character)
		{
			if (character.Monster_ID != 0) //Updating Item
				return database.UpdateAsync(character);
			return database.InsertAsync(character);
		}

		public Task<int> deleteMonster(Character character)
		{
			return database.DeleteAsync(character);
		}

        //********************************************API DATA*************************************************************

        public Task<List<apiData>> RetrieveAPI()
        {
            return database.Table<apiData>().ToListAsync();
        }

        public Task<int> InsertAPI(apiData data)
        {
            if (data.ApiID != 0) //Updating Item
                return database.UpdateAsync(data);

            return database.InsertAsync(data);
        }

        public Task<int> deleteAPI(apiData data)
        {
            return database.DeleteAsync(data);
            
        }

        public void dropAPI()
        {
            System.Diagnostics.Debug.Write("IM IN HERE");
              database.DropTableAsync<apiData>();

        }

        public void reset()
        {
            database.ExecuteAsync("DELETE FROM apiData");
        }
    }
}
