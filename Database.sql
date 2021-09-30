CREATE TABLE [invoice_items] (
  [id] int NOT NULL IDENTITY,
  [invoice_id] int DEFAULT NULL,
  [name] varchar(255) DEFAULT NULL,
  [amount] decimal(15,5) DEFAULT NULL,
  [created_at] datetime2 NULL DEFAULT NULL,
  PRIMARY KEY ([id])
) 


set identity_insert [invoice_items] ON
INSERT INTO [invoice_items] ([id], invoice_id, [name], [amount], [created_at])
VALUES (1,5,'Service Cost',433.00000,'2017-05-19 00:00:00'),
(2,4,'Service Cost',486.00000,'2017-05-12 00:00:00'),
(3,6,'Additional Items',532.00000,'2017-06-05 00:00:00'),
(4,3,'Service Cost',246.00000,'2017-04-08 00:00:00'),
(5,1,'Service Cost',888.00000,'2017-03-29 00:00:00'),(6,7,'Additional Items',64.00000,'2017-06-08 00:00:00'),(7,7,'Service Cost',443.00000,'2017-06-15 00:00:00'),
(8,8,'Additional Items',999.00000,'2017-07-03 00:00:00'),(9,4,'Additional Items',446.00000,'2017-05-12 00:00:00'),
(10,2,'Additional Items',257.00000,'2017-03-30 00:00:00'),(11,5,'Additional Items',733.00000,'2017-05-19 00:00:00'),
(12,10,'Additional Items',553.00000,'2017-08-14 00:00:00'),(13,10,'Service Cost',224.00000,'2017-08-14 00:00:00'),
(14,9,'Additional Items',45.00000,'2017-07-26 00:00:00'),(15,1,'Additional Items',55.00000,'2017-03-29 00:00:00'),
(16,2,'Service Cost',965.00000,'2017-03-30 00:00:00'),(17,8,'Service Cost',923.00000,'2017-07-03 00:00:00'),(18,9,'Service Cost',48.00000,'2017-07-26 00:00:00'),
(19,7,'Package 23',663.00000,'2017-06-15 00:00:00'),(20,6,'Service Cost',368.00000,'2017-06-05 00:00:00'),(21,3,'Additional Items',93.00000,'2017-04-08 00:00:00'),
(22,4,'Package 34',688.00000,'2017-05-12 00:00:00'),(23,4,'Package 1',4396.00000,'2017-05-12 00:00:00'),(24,5,'Package 45',343.00000,'2017-05-19 00:00:00');
set identity_insert [invoice_items] OFF

CREATE TABLE [invoices] (
  [InvoiceId] int NOT NULL IDENTITY,
  [Client] varchar(255) DEFAULT NULL,
  [InvoiceAmount] decimal(15,5) DEFAULT NULL,
  [InvoiceAmountPlusVat] decimal(15,5) DEFAULT NULL,
  [VatRate] decimal(15,5) DEFAULT NULL,
  [InvoiceStatus] nvarchar(50) DEFAULT NULL,
  [InvoiceDate] date DEFAULT NULL,
  [CreatedAt] datetime2 NULL DEFAULT NULL,
  PRIMARY KEY ([InvoiceId])
) 


set identity_insert [invoices] ON
INSERT INTO [invoices] ( [InvoiceId], [Client], [InvoiceAmount], [InvoiceAmountPlusVat], [VatRate], [InvoiceStatus], [InvoiceDate], [CreatedAt])
VALUES (1,'ACME Chemicals B.V.',943.00000,1141.03000,21.00000,'paid','2017-03-29','2017-03-29 00:00:00'),(2,'ICS Digital B.V.',1222.00000,1478.62000,21.00000,'unpaid','2017-03-30','2017-03-30 00:00:00'),(3,'Shell Foods B.V.',339.00000,410.19000,21.00000,'unpaid','2017-04-08','2017-04-08 00:00:00'),(4,'DDY Entertainment B.V.',6016.00000,7279.36000,21.00000,'paid','2017-05-12','2017-05-12 00:00:00'),(5,'ALbert Hiejn B.V.',1509.00000,1750.44000,16.00000,'unpaid','2017-05-19','2017-05-19 00:00:00'),(6,'Woolworths B.V.',900.00000,1044.00000,16.00000,'unpaid','2017-06-05','2017-06-05 00:00:00'),(7,'Select Systems B.V.',1170.00000,1415.70000,21.00000,'paid','2017-06-08','2017-06-08 00:00:00'),(8,'Fedhealth Inc',1922.00000,2325.62000,21.00000,'unpaid','2017-07-03','2017-07-03 00:00:00'),(9,'Auto & General',93.00000,108.81000,17.00000,'unpaid','2017-07-26','2017-07-26 00:00:00'),(10,'Vaca Loca Bar',777.00000,909.09000,17.00000,'paid','2017-08-14','2017-08-14 00:00:00');
set identity_insert [invoices] OFF
