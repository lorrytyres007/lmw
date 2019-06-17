delete from tbl_VoucherEntry
delete from tbl_ThriftDeposit
delete from tbl_HeadOpening
delete from tbl_Head
Delete from tbl_Group
Delete from tbl_Member
delete from tbl_Company



insert into tbl_Company
	select * from LMW1..tbl_Company
insert into tbl_Member
	select * from LMW1..tbl_Member
insert into tbl_Group
	select * from LMW1..tbl_Group
insert into tbl_HEad
	select * from LMW1..tbl_HEad
insert into tbl_HeadOpening
	select * from LMW1..tbl_HeadOpening
insert into tbl_ThriftDeposit
	select * from LMW1..tbl_ThriftDeposit
insert into tbl_VoucherEntry
	select * from LMW1..tbl_VoucherEntry

