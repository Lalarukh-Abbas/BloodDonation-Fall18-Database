create procedure RequestDelivery
as
select Request.idRequestid,Bg.GrpName [Requested Blood Group], deliveryDate

from Hospital H Inner Join hospital_has_Request hhr on H.idhospital = hhr.Hospital_idhospital
	Inner Join Request_has_BloodGrp rhb on hhr.Request_idRequestid = rhb.Request_idRequestid
	Inner Join Request on hhr.Request_idRequestid = Request.idRequestid

Inner Join BloodGrp Bg on rhb.BloodGrp_idBloodGrp = Bg.idBloodGrp
where deliveryDate>GETDATE() or deliveryDate=GETDATE()

go;
drop procedure RequestDelivery 
--drop procedure HospitalRequests
--contactPerson,contactPhone,contactEmail as [Email],[address]
create procedure Hospitals
as
select HName,contactPerson,contactPhone,contactEmail,[address],
hhr.Request_idRequestid,Bg.GrpName

from Hospital H Inner Join hospital_has_Request hhr on H.idhospital = hhr.Hospital_idhospital
	Inner Join Request_has_BloodGrp rhb on hhr.Request_idRequestid = rhb.Request_idRequestid

Inner Join BloodGrp Bg on rhb.BloodGrp_idBloodGrp = Bg.idBloodGrp

go

