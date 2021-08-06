/*------------------------------------------------------------
*        Script SQLSERVER 
------------------------------------------------------------*/


/*------------------------------------------------------------
-- Table: LOC
------------------------------------------------------------*/
CREATE TABLE LOC(
	LOC_ID    INT IDENTITY (1,1) NOT NULL ,
	LOC_CP    VARCHAR (10) NOT NULL ,
	LOC_NOM   VARCHAR (70) NOT NULL  ,
	CONSTRAINT LOC_PK PRIMARY KEY (LOC_ID)
);


/*------------------------------------------------------------
-- Table: MBR
------------------------------------------------------------*/
CREATE TABLE MBR(
	MBR_ID         INT IDENTITY (1,1) NOT NULL ,
	MBR_NOM        VARCHAR (60) NOT NULL ,
	MBR_PRN        VARCHAR (50) NOT NULL ,
	MBR_SEX        CHAR (1)   ,
	MBR_DTE_NAI    DATETIME NOT NULL ,
	MBR_DTE_INS    DATETIME NOT NULL ,
	MBR_RUE        VARCHAR (100) NOT NULL ,
	MBR_NOM_RES    VARCHAR (80)  ,
	MBR_NUM_IMM    VARCHAR (5)  ,
	MBR_NUM_BTE    VARCHAR (5) NOT NULL ,
	MBR_NUM_TEL    VARCHAR (10)  ,
	MBR_NUM_GSM    VARCHAR (10) NOT NULL ,
	MBR_ADR_MAIL   VARCHAR (50) NOT NULL ,
	MBR_ADM        bit  NOT NULL ,
	MBR_USR_PSD    VARCHAR NULL (50) ,
	MBR_USR_PWD    VARCHAR NULL (50) ,
	LOC_ID         INT  NOT NULL  ,
	CONSTRAINT MBR_PK PRIMARY KEY (MBR_ID)

	,CONSTRAINT MBR_LOC_FK FOREIGN KEY (LOC_ID) REFERENCES LOC(LOC_ID)
);


/*------------------------------------------------------------
-- Table: PIL
------------------------------------------------------------*/
CREATE TABLE PIL(
	MBR_ID            INT  NOT NULL ,
	PIL_NUM_LIC       VARCHAR (15) NOT NULL ,
	PIL_LIC_DTE_OBT   DATETIME NOT NULL ,
	PIL_LIC_DTE_EXP   DATETIME  ,
	PIL_LIC_PAYS      CHAR (2)  NOT NULL ,
	CONSTRAINT PIL_PK PRIMARY KEY (MBR_ID)

	,CONSTRAINT PIL_MBR_FK FOREIGN KEY (MBR_ID) REFERENCES MBR(MBR_ID)
	,CONSTRAINT PIL_LOC0_FK FOREIGN KEY (LOC_ID) REFERENCES LOC(LOC_ID)
);


/*------------------------------------------------------------
-- Table: RES
------------------------------------------------------------*/
CREATE TABLE RES(
	RES_ID        INT IDENTITY (1,1) NOT NULL ,
	RES_DTE       DATETIME NOT NULL ,
	RES_HEU_DEB   TIME (2) NOT NULL ,
	RES_HEU_FIN   TIME (2) NOT NULL ,
	MBR_ID        INT  NOT NULL  ,
	CONSTRAINT RES_PK PRIMARY KEY (RES_ID)

	,CONSTRAINT RES_PIL_FK FOREIGN KEY (MBR_ID) REFERENCES PIL(MBR_ID)
);


/*------------------------------------------------------------
-- Table: TYP
------------------------------------------------------------*/
CREATE TABLE TYP(
	TYP_ID    INT IDENTITY (1,1) NOT NULL ,
	TYP_NOM   VARCHAR (50) NOT NULL ,
	TYP_DES   VARCHAR (1000) NOT NULL  ,
	CONSTRAINT TYP_PK PRIMARY KEY (TYP_ID)
);


/*------------------------------------------------------------
-- Table: AER
------------------------------------------------------------*/
CREATE TABLE AER(
	AER_ID     INT IDENTITY (1,1) NOT NULL ,
	AER_IMA    VARCHAR (100) NOT NULL ,
	AER_TYPE   VARCHAR (200) NOT NULL ,
	TYP_ID     INT  NOT NULL  ,
	CONSTRAINT AER_PK PRIMARY KEY (AER_ID)

	,CONSTRAINT AER_TYP_FK FOREIGN KEY (TYP_ID) REFERENCES TYP(TYP_ID)
);


/*------------------------------------------------------------
-- Table: IND
------------------------------------------------------------*/
CREATE TABLE IND(
	IND_ID        INT IDENTITY (1,1) NOT NULL ,
	IND_DTE_DEB   DATETIME NOT NULL ,
	IND_HEU_DEB   TIME (2) NOT NULL ,
	IND_DTE_FIN   DATETIME NOT NULL ,
	IND_HEU_FIN   TIME (2) NOT NULL ,
	IND_DES       VARCHAR (1000) NOT NULL ,
	AER_ID        INT    ,
	CONSTRAINT IND_PK PRIMARY KEY (IND_ID)

	,CONSTRAINT IND_AER_FK FOREIGN KEY (AER_ID) REFERENCES AER(AER_ID)
);


/*------------------------------------------------------------
-- Table: SYM
------------------------------------------------------------*/
CREATE TABLE SYM(
	MBR_ID         INT  NOT NULL ,
	CONSTRAINT SYM_PK PRIMARY KEY (MBR_ID)

	,CONSTRAINT SYM_MBR_FK FOREIGN KEY (MBR_ID) REFERENCES MBR(MBR_ID)
	,CONSTRAINT SYM_LOC0_FK FOREIGN KEY (LOC_ID) REFERENCES LOC(LOC_ID)
);


/*------------------------------------------------------------
-- Table: ANNU
------------------------------------------------------------*/
CREATE TABLE ANNU(
	ANNU_ID      INT IDENTITY (1,1) NOT NULL ,
	ANNU_MOTIF   VARCHAR (1000) NOT NULL ,
	ANNU_DTE     DATETIME NOT NULL ,
	ANNU_HEU     TIME (2) NOT NULL  ,
	CONSTRAINT ANNU_PK PRIMARY KEY (ANNU_ID)
);


/*------------------------------------------------------------
-- Table: PIST
------------------------------------------------------------*/
CREATE TABLE PIST(
	PIST_ID      INT IDENTITY (1,1) NOT NULL ,
	PIST_DISPO   bit  NOT NULL  ,
	CONSTRAINT PIST_PK PRIMARY KEY (PIST_ID)
);


/*------------------------------------------------------------
-- Table: COTI
------------------------------------------------------------*/
CREATE TABLE COTI(
	COTI_ID        INT IDENTITY (1,1) NOT NULL ,
	COTI_DTE_EMI   DATETIME NOT NULL ,
	COTI_DTE_PAI   DATETIME NOT NULL ,
	COTI_MONT      DECIMAL  NOT NULL ,
	MBR_ID         INT  NOT NULL  ,
	CONSTRAINT COTI_PK PRIMARY KEY (COTI_ID)

	,CONSTRAINT COTI_MBR_FK FOREIGN KEY (MBR_ID) REFERENCES MBR(MBR_ID)
);


/*------------------------------------------------------------
-- Table: RET
------------------------------------------------------------*/
CREATE TABLE RET(
	RET_ID        INT IDENTITY (1,1) NOT NULL ,
	RET_DTE_DEB   DATETIME NOT NULL ,
	RET_DTE_FIN   DATETIME NOT NULL ,
	RET_MOTIF     VARCHAR (1000) NOT NULL ,
	MBR_ID        INT  NOT NULL  ,
	CONSTRAINT RET_PK PRIMARY KEY (RET_ID)

	,CONSTRAINT RET_PIL_FK FOREIGN KEY (MBR_ID) REFERENCES PIL(MBR_ID)
);


/*------------------------------------------------------------
-- Table: CON
------------------------------------------------------------*/
CREATE TABLE CON(
	RES_ID    INT  NOT NULL ,
	AER_ID    INT  NOT NULL ,
	PIST_ID   INT  NOT NULL  ,
	CONSTRAINT CON_PK PRIMARY KEY (RES_ID,AER_ID,PIST_ID)

	,CONSTRAINT CON_RES_FK FOREIGN KEY (RES_ID) REFERENCES RES(RES_ID)
	,CONSTRAINT CON_AER0_FK FOREIGN KEY (AER_ID) REFERENCES AER(AER_ID)
	,CONSTRAINT CON_PIST1_FK FOREIGN KEY (PIST_ID) REFERENCES PIST(PIST_ID)
);


/*------------------------------------------------------------
-- Table: QUAL
------------------------------------------------------------*/
CREATE TABLE QUAL(
	TYP_ID   INT  NOT NULL ,
	MBR_ID   INT  NOT NULL  ,
	CONSTRAINT QUAL_PK PRIMARY KEY (TYP_ID,MBR_ID)

	,CONSTRAINT QUAL_TYP_FK FOREIGN KEY (TYP_ID) REFERENCES TYP(TYP_ID)
	,CONSTRAINT QUAL_PIL0_FK FOREIGN KEY (MBR_ID) REFERENCES PIL(MBR_ID)
);


/*------------------------------------------------------------
-- Table: SUB
------------------------------------------------------------*/
CREATE TABLE SUB(
	ANNU_ID   INT  NOT NULL ,
	RES_ID   INT  NOT NULL  ,
	CONSTRAINT SUB_PK PRIMARY KEY (ANNU_ID,RES_ID)

	,CONSTRAINT SUB_ANNU_FK FOREIGN KEY (ANNU_ID) REFERENCES ANNU(ANNU_ID)
	,CONSTRAINT SUB_RES0_FK FOREIGN KEY (RES_ID) REFERENCES RES(RES_ID)
);



