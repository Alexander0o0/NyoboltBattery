import random
import datetime

today = datetime.date.today()
num = random.randint(1,1000)
# Generate the data for the battery
BatVol = random.randint(0, 500)
BatCap = random.randint(0,65)
Temp = random.randint(0,140)
SOC = random.randint(0,100)
SOH = random.randint(0,100)

# Write data to text file
with open(f'{today}{num}.txt', 'w') as file:
    file.write(f'Date: {today}\n')
    file.write(f'Battery Voltage: {BatVol}V\n')
    file.write(f'Battery Capacity: {BatCap}kWh\n')
    file.write(f'Temperature: {Temp}*C\n')
    file.write(f'State of Charge: {SOC}%\n')
    file.write(f'State of Health: {SOH}%\n')
