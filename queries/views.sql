select Name,CNIC,ContactNo, GrpName
from BloodGrp Inner Join Donor on Donor.BloodGrp_idBloodGrp = BloodGrp.idBloodGrp
select * from Donor
create view [Successful Results] as
select idBlood,DonatedBlood.Donation_idDonation, dateDonation,Amount
from ScreenedDB Inner Join DonatedBlood on ScreenedDB.DonatedBlood_idBlood = DonatedBlood.idBlood Inner Join Donation on Donation.idDonation = DonatedBlood.Donation_idDonation
where Status_2 = 'successful'

create view [Unsuccessful Results] as
select idBlood,DonatedBlood.Donation_idDonation, dateDonation,Amount
from ScreenedDB Inner Join DonatedBlood on ScreenedDB.DonatedBlood_idBlood = DonatedBlood.idBlood Inner Join Donation on Donation.idDonation = DonatedBlood.Donation_idDonation
where Status_2 = 'unsuccessful'

select * from DonatedBlood