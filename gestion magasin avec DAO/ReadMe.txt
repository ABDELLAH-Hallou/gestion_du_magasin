#########Abdellah Hallou######################################
la réalisation de cette application ce fait à l'aide de windows form
pour le rendre plus structurel.
l'application peut faire :
	l'insertion d'un ligne dans un table : Add
	suppression d'un ligne dans un table : delete
		->vous douvez selectioner un ligne et 
		click sur le button delete puis yes. 
	la modification d'un ligne dans un table : Update
	l'affichage des donnee d'un table : Show Table
		->à l'aide de datagridview ,
et tous ça dans dans le mode connecter, et avec DAO 
->chaque table a un classe qui contient ses attributs et ces constructeurs
->chaque table a un interface qui contient le signateur de leurs methods tel que : 
							Add();
							Update();
							Delete();
							Show(); //pour afficher les donnee de table
->tous les classe puvent connecter avec la base de donnee à l'aide de classe MyConnexion;