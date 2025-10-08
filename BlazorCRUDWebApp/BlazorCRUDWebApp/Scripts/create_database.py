import sqlite3
from synthetic_date import *



class PeopleTable:
    def __init__(self):  
        self.id = None       
        self.name = ''  
        self.gender = ''                 
        self.position = ''
        self.birthdate = 0
        self.salary = 0
        self.database_path = "../Database/EmpoloyeesDB.db"


    # -------------------------database-----------------------------
    #         id INTEGER PRIMARY KEY AUTOINCREMENT,
    def create_db(self):
        sqliteConnection = sqlite3.connect(self.database_path)
        cursor = sqliteConnection.cursor()
        cursor.execute("""CREATE TABLE IF NOT EXISTS people(
        id TEXT PRIMARY KEY,
        name TEXT,
        gender TEXT,
        position TEXT,
        birthdate INTEGER,
        salary INTEGER)
                        """)
        cursor.close()


    def insert_date_db(self, _id, _name, _gender, _position, _birthdate, _salary):
        sqliteConnection = sqlite3.connect(self.database_path)
        cursor = sqliteConnection.cursor()
        add_to_table = "INSERT INTO people (id, name, gender, position, birthdate, salary) values (?, ?, ?, ?, ?, ?)"
        cursor.execute(add_to_table, (_id, _name, _gender, _position, _birthdate, _salary))
        #print(_unique_id, _name, _gender, _position, _birthdate, _salary)
        sqliteConnection.commit()
        cursor.close()

                              
    # -------------- data creation --------------------    
    # Индекс сквозной нумерации
    def index_func(self):
        if self.employe_index == None:
            self.employe_index = 1               
        else:
            self.employe_index += 1 
        return self.employe_index    


    # Собираем результат
    def main(self):
        #self.create_db()
        for i in range(1, 100, 1):
            _id = generate_id()
            name_gender = get_name_gender()
            name = name_gender['name']
            gender = name_gender['gender']
            position = get_position()
            birthdate = generate_birthdate(1955, 2017, 1)
            salary = generate_salary(60000, 300000, 1000)
            self.insert_date_db(_id, name, gender, position, birthdate, salary)
        print('done')
        


#table = PeopleTable()
#table.main()

