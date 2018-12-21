CREATE TABLE Request (
  idRequestid INTEGER  NOT NULL,
  deliveryDate DATE  NOT NULL  ,
  status_2 VARCHAR(50)  NOT NULL    ,
PRIMARY KEY(idRequestid));
GO




CREATE TABLE Nurse (
  idNurse INTEGER  NOT NULL,
  Name_Nurse VARCHAR(255)  NOT NULL  ,
  NIC_N INTEGER  NOT NULL  ,
  phoneNo VARCHAR(50)  NOT NULL  ,
  address_N VARCHAR(255)  NOT NULL    ,
PRIMARY KEY(idNurse));
GO




CREATE TABLE Hospital (
  idhospital INTEGER  NOT NULL,
  HName VARCHAR(255)  NOT NULL  ,
  contactPerson VARCHAR(255)  NOT NULL  ,
  contactPhone INTEGER  NOT NULL  ,
  contactEmail VARCHAR(255)  NOT NULL  ,
  address VARCHAR(255)  NOT NULL    ,
PRIMARY KEY(idhospital));
GO




CREATE TABLE Donation (
  idDonation INTEGER  NOT NULL,
  dateDonation DATE  NOT NULL    ,
PRIMARY KEY(idDonation));
GO




CREATE TABLE BloodGrp (
  idBloodGrp INTEGER  NOT NULL    ,
  GrpName VARCHAR(255)      ,
PRIMARY KEY(idBloodGrp));
GO




CREATE TABLE Request_has_BloodGrp (
  Request_idRequestid INTEGER  NOT NULL  ,
  BloodGrp_idBloodGrp INTEGER  NOT NULL    ,
PRIMARY KEY(Request_idRequestid, BloodGrp_idBloodGrp)    ,
  FOREIGN KEY(Request_idRequestid)
    REFERENCES Request(idRequestid),
  FOREIGN KEY(BloodGrp_idBloodGrp)
    REFERENCES BloodGrp(idBloodGrp));
GO


CREATE INDEX Request_has_BloodGrp_FKIndex1 ON Request_has_BloodGrp (Request_idRequestid);
GO
CREATE INDEX Request_has_BloodGrp_FKIndex2 ON Request_has_BloodGrp (BloodGrp_idBloodGrp);
GO


CREATE INDEX IFK_Rel_20 ON Request_has_BloodGrp (Request_idRequestid);
GO
CREATE INDEX IFK_Rel_21 ON Request_has_BloodGrp (BloodGrp_idBloodGrp);
GO


CREATE TABLE hospital_has_Request (
  Hospital_idhospital INTEGER  NOT NULL  ,
  Request_idRequestid INTEGER  NOT NULL    ,
PRIMARY KEY(Hospital_idhospital, Request_idRequestid)    ,
  FOREIGN KEY(Hospital_idhospital)
    REFERENCES Hospital(idhospital),
  FOREIGN KEY(Request_idRequestid)
    REFERENCES Request(idRequestid));
GO


CREATE INDEX hospital_has_Request_FKIndex1 ON hospital_has_Request (Hospital_idhospital);
GO
CREATE INDEX hospital_has_Request_FKIndex2 ON hospital_has_Request (Request_idRequestid);
GO


CREATE INDEX IFK_Rel_05 ON hospital_has_Request (Hospital_idhospital);
GO
CREATE INDEX IFK_Rel_06 ON hospital_has_Request (Request_idRequestid);
GO


CREATE TABLE DonatedBlood (
  idBlood INTEGER  NOT NULL    ,
  BloodGrp_idBloodGrp INTEGER  NOT NULL  ,
  Donation_idDonation INTEGER  NOT NULL  ,
  Amount INTEGER      ,
PRIMARY KEY(idBlood)    ,
  FOREIGN KEY(Donation_idDonation)
    REFERENCES Donation(idDonation),
  FOREIGN KEY(BloodGrp_idBloodGrp)
    REFERENCES BloodGrp(idBloodGrp));
GO


CREATE INDEX DonatedBlood_FKIndex2 ON DonatedBlood (Donation_idDonation);
GO
CREATE INDEX DonatedBlood_FKIndex3 ON DonatedBlood (BloodGrp_idBloodGrp);
GO


CREATE INDEX IFK_Rel_19 ON DonatedBlood (Donation_idDonation);
GO
CREATE INDEX IFK_Rel_12 ON DonatedBlood (BloodGrp_idBloodGrp);
GO


CREATE TABLE Donor (
  idDonor INTEGER  NOT NULL    ,
  BloodGrp_idBloodGrp INTEGER  NOT NULL  ,
  Donation_idDonation INTEGER  NOT NULL  ,
  Name VARCHAR(255)    ,
  DOB DATE    ,
  weight FLOAT    ,
  bloodPressure INTEGER    ,
  address VARCHAR(255)    ,
  ContactNo VARCHAR(255)    ,
  City VARCHAR(255)    ,
  Gender CHAR    ,
  CNIC INTEGER    ,
  Haemoglobin FLOAT      ,
PRIMARY KEY(idDonor)    ,
  FOREIGN KEY(Donation_idDonation)
    REFERENCES Donation(idDonation),
  FOREIGN KEY(BloodGrp_idBloodGrp)
    REFERENCES BloodGrp(idBloodGrp));
GO


CREATE INDEX Donor_FKIndex2 ON Donor (Donation_idDonation);
GO
CREATE INDEX Donor_FKIndex2000 ON Donor (BloodGrp_idBloodGrp);
GO


CREATE INDEX IFK_Rel_23 ON Donor (Donation_idDonation);
GO
CREATE INDEX IFK_Rel_11 ON Donor (BloodGrp_idBloodGrp);
GO


CREATE TABLE Donation_has_Nurse (
  Donation_idDonation INTEGER  NOT NULL  ,
  Nurse_idNurse INTEGER  NOT NULL    ,
PRIMARY KEY(Donation_idDonation, Nurse_idNurse)    ,
  FOREIGN KEY(Donation_idDonation)
    REFERENCES Donation(idDonation),
  FOREIGN KEY(Nurse_idNurse)
    REFERENCES Nurse(idNurse));
GO


CREATE INDEX Donation_has_employee_FKIndex1 ON Donation_has_Nurse (Donation_idDonation);
GO
CREATE INDEX Donation_has_employee_FKIndex2 ON Donation_has_Nurse (Nurse_idNurse);
GO


CREATE INDEX IFK_Rel_14 ON Donation_has_Nurse (Donation_idDonation);
GO
CREATE INDEX IFK_Rel_15 ON Donation_has_Nurse (Nurse_idNurse);
GO


CREATE TABLE ScreenedDB (
  idScreening INTEGER  NOT NULL  ,
  DonatedBlood_idBlood INTEGER  NOT NULL  ,
  HIV_1 bit    ,
  HIV_2 bit    ,
  HTLV_1 bit    ,
  HTLV_2 bit    ,
  HepB bit    ,
  HepC bit    ,
  Syphilis bit    ,
  Status_2 VARCHAR(20)      ,
PRIMARY KEY(idScreening)  ,
  FOREIGN KEY(DonatedBlood_idBlood)
    REFERENCES DonatedBlood(idBlood));
GO


CREATE INDEX Table_12_FKIndex1 ON ScreenedDB (DonatedBlood_idBlood);
GO


CREATE INDEX IFK_Rel_13 ON ScreenedDB (DonatedBlood_idBlood);
GO



