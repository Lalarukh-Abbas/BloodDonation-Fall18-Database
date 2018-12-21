CREATE PROCEDURE GetDonorDonationRecord @Donor_id Integer
AS
--Donationid,DonationDate,DonorID,nurseid,amount
select GDR.idDonation,GDR.dateDonation,GDR.idDonor as Donor,N.Name_Nurse as Nurse,BG.GrpName as [Blood Group],GDR.Amount as[Amount (cc)]
from
(SELECT Dona.idDonation,Dona.dateDonation,Don.idDonor,D_H_N.Nurse_idNurse,DB.BloodGrp_idBloodGrp,DB.Amount
from Donation Dona Inner Join Donor Don on Dona.idDonation = Don.Donation_idDonation
Inner Join Donation_has_Nurse D_H_N on Dona.idDonation = D_H_N.Donation_idDonation
Inner Join DonatedBlood DB on DB.Donation_idDonation = Dona.idDonation
where @Donor_id = Don.idDonor) as GDR

Inner Join Nurse N on N.idNurse = GDR.Nurse_idNurse Inner Join BloodGrp BG on BG.idBloodGrp = GDR.BloodGrp_idBloodGrp

GO;

