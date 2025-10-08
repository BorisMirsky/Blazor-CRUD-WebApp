import random
from datetime import timedelta
import datetime
import uuid
from russian_names import RussianNames


def generate_id():
    result = str(uuid.uuid4()).upper()
    return result

def random_gender():
    return random.randint(0, 1) 

def get_name_gender(): 
    g = random_gender()
    result = {}
    result['name'] = RussianNames(gender=g).get_person()
    if g == 0:
        result['gender'] = 'female'
    else:
        result['gender'] = 'male'
    return result

def get_position():
    position = ['manager', 'clerk', 'vender']
    idx = random.randrange(len(position))
    return position[idx]

def generate_birthdate(start, stop, step):
    return random.randrange(start, stop, step)

def generate_salary(start, stop, step):
    return random.randrange(start, stop, step)   
    
#print(type(generate_id()))
#print(get_name_gender())
#print(get_position())
#print(generate_birthdate(1955, 2008, 1))
#print(generate_salary(60000, 300000, 1000))



    
