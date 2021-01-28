CREATE TABLE [dbo].[PaymentDetails]
(
	[PaymentID] INT NOT NULL, 
    [Amount] NCHAR(10) NOT NULL, 
    [Date] DATETIME NOT NULL, 
    [AccountNo] VARCHAR(8) NULL, 
    CONSTRAINT [PK_PaymentDetails] PRIMARY KEY ([PaymentID]) ,
    CONSTRAINT FK_AccountNo FOREIGN KEY (AccountNo)
    REFERENCES AccountDetails(AccountNo)
)
