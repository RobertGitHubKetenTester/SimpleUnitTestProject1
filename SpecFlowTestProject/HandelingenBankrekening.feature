Feature: HandelingenBankrekening
	Teneinde het Banksysteem te testen
	Wil ik als een echte bankier een aantal transacties met bankrekeningen doen


Scenario: Maak rekeningen en doe een transactie
	Given Ik stort 100 op een eerste rekening
	And  Ik stort 50 op een tweede rekening
	When Ik maak 20 over tussen deze rekeningen
	And ik vraag de respectieve saldi op
	Then zijn deze saldi 80 en 70

	## nogmaals met kleine variatie, om Specrun te testen
	@magnietcommandline
Scenario: Maak andere rekeningen en doe een transactie
	Given Ik stort 200 op een eerste rekening
	And  Ik stort 150 op een tweede rekening
	When Ik maak 20 over tussen deze rekeningen
	And ik vraag de respectieve saldi op
	Then zijn deze saldi 180 en 170

