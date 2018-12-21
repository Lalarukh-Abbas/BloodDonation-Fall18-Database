bulk insert donor
from 'C:\git\BloodDonation-Fall18-Database\Data_CSV_20-12\Database-donor2.csv'
with
(
rowterminator = '\n',
fieldterminator = ','
)
bulk insert BloodGrp
from 'C:\git\BloodDonation-Fall18-Database\Data_CSV_20-12\BloodGrp.csv'
with
(
rowterminator = '\n',
fieldterminator = ','
)
bulk insert Hospital
--Database-Hospital.csv
from 'C:\git\BloodDonation-Fall18-Database\Data_CSV_20-12\Database-Hospital.csv'
with
(
rowterminator = '\n',
fieldterminator = ','
)
bulk insert Donation
from 'C:\git\BloodDonation-Fall18-Database\Data_CSV_20-12\Database-Donation.csv'
with
(
rowterminator = '\n',
fieldterminator = ','
)
bulk insert Request
from 'C:\git\BloodDonation-Fall18-Database\Data_CSV_20-12\Database-Request.csv'
--test3.csv
with
(
rowterminator = '\n',
fieldterminator = ','
)
bulk insert Request_has_BloodGrp
from 'C:\git\BloodDonation-Fall18-Database\Data_CSV_20-12\final\Database-Request_has_BloodGrp.csv'
--test3.csv
with
(
rowterminator = '\n',
fieldterminator = ','
)
bulk insert DonatedBlood
from 'C:\git\BloodDonation-Fall18-Database\Data_CSV_20-12\DonatedBlood.csv'
--test3.csv
with
(
rowterminator = '\n',
fieldterminator = ','
)
bulk insert Nurse
from 'C:\git\BloodDonation-Fall18-Database\Data_CSV_20-12\Database-Nurse.csv'
--test3.csv
with
(
rowterminator = '\n',
fieldterminator = ','
)
bulk insert Donation_has_Nurse
from 'C:\git\BloodDonation-Fall18-Database\Data_CSV_20-12\Donation_has_Nurse.csv'
--test3.csv
with
(
rowterminator = '\n',
fieldterminator = ','
)
bulk insert hospital_has_Request
from 'C:\git\BloodDonation-Fall18-Database\Data_CSV_20-12\Database-hospital_has_Request.csv'

with
(
rowterminator = '\n',
fieldterminator = ','
)
--ScreeningDB
bulk insert ScreenedDB
from 'C:\git\BloodDonation-Fall18-Database\Data_CSV_20-12\ScreeningDB.csv'

with
(
rowterminator = '\n',
fieldterminator = ','
)
