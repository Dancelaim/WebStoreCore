Begin Try
    SET NOCOUNT ON
    Set XACT_ABORT ON
Begin Tran
exec Check_db_Version 1

ALTER TABLE ProductOptionParams
ADD CONSTRAINT FK_ProductOptionParams_ProductOptions
FOREIGN KEY (ParentOptionId) REFERENCES ProductOptions(OptionId)

ALTER TABLE TempOptionParams
ADD CONSTRAINT FK_TempOptionParams_TemplateOptions
FOREIGN KEY (ParentOptionId) REFERENCES TemplateOptions(OptionId)

ALTER TABLE ProductOptions
ALTER COLUMN OptionType int

--update ProductOptions 
--set OptionType = '0'
--where OptionType ='CheckBox'

--update ProductOptions 
--set OptionType ='3' 
--where OptionType = 'DropDownList'

exec Update_db_Version 1
Commit Tran
End Try
Begin Catch
   RollBack Tran
   Select ERROR_MESSAGE() as Msg, ERROR_NUMBER() as Num
End Catch