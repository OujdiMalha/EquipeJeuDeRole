# EquipeJeuDeRole
Membres : Mohammed - Fabrice - Virgile � Nathan


Diagramme de classe�: (voir dans le dossier)




Notre jeu de r�le d�velopp� avec Blazor WebAssembly en C#.

Boutons principaux :

o La page affiche un titre "Jeu de r�le" et propose un bouton "Nouvelle Partie" qui, lorsqu'il est cliqu�, appelle la m�thode NouvellePartie.

o  Bouton de navigation navigation vers d'autres pages telles que "Plateau" et "ZoneCombat". Ce bouton peuvent �tre utilis�s pour diriger le joueur vers diff�rentes sections du jeu, apr�s avoir cr�� son personnage.


Options suppl�mentaires :

o La page propose �galement des boutons pour charger une partie pr�c�demment sauvegard�e et quitter le jeu.

Fonctions associ�es :


o La m�thode NouvellePartie est responsable de la suppression des donn�es de l'�tat de la page (sauvegard�es localement) et de la navigation vers la page de cr�ation de personnage.
o La m�thode ChoisirPersonnage serait  utilis�e pour la logique de choix du personnage (Guerrier, Sorcier, Archer).
o La m�thode ChargerPartie  serait probablement utilis�e pour charger une partie sauvegard�e et naviguer vers la page du plateau de jeu.
o Les m�thodes AfficherOptions et ModifierParametre est r�serv�es pour des fonctionnalit�s futures li�es � l'affichage des options et � la modification des param�tres du jeu.
o La m�thode Quitter est r�serv�e pour la logique de quitter le jeu.
