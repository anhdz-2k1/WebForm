CREATE TABLE product(
    Id   INT            NOT NULL,
    Name NVARCHAR (255) NULL,
	Author NVARCHAR (255) NULL,
	Summary NVARCHAR (555) NULL,
    Qty   INT            NULL,
    Price int NULL,
    CONSTRAINT PK_Table_product PRIMARY KEY (Id)
);