
# documentation MVC



.NET Framework: 
Compos� de 2 choses:
1. Ensemble de Librairies de programmation
- XML
- ADO.NET
- ASP.NET Web Forms 
- ASP.NET MVC
- Entity Framework
- WPF
- WCF
- Windows Forms
- LINQ-to-Objects

2.  Environnement d'�x�cution (Runtime)
CLR   (Common Language Runtime)
- Load Library
- Gestion m�moire (garbage collection)
- JIT Compiler (Just in time)
- interop
- Thread
- Exception
- Type safety
- Securit�
- Base Class Library (BCL)
- etc



----------------
<table>
<tr>
	<td>1.0</td><td>2002</td><td>Lib + CLR</td>
 </tr>
<tr>
	<td>2.0</td><td>2003</td><td>Lib + CLR</td>
 </tr>


</table>

1.0  | 2002 |     Lib + CLR
1.1  | 2003 |    Lib + CLR
2.0  | 2005 |    Lib + CLR
3.0  | 2007 |   Lib
3.5  | 2008 |   Lib
4.0  | 2010 |   Lib + CLR
4.5  | 2012 |   Lib + CLR  (�crase 4.0)
4.6  | 2015 |   Lib + CLR  (�crase 4.0)

.NET Framework Core 1.0   CLR r�invent�  2016
Cross-platform (Windows, Mac, Linux, RasberryPi)
Modulaire
Open Source 

- limit� library
- VS2017  et plus

-------

ASP.NET Core 1.0 (MVC, Razor, Web Api, SignalR... MAIS pas de WebForms)


-------------------------------------------


ASP                1996    Bas� sur VbScript
ASP.NET WebForms   2002    Bas� sur .NET, Abstraction Windows
ASP.NET MVC        2009    Bas� sur .NET, Abstraction Web
ASP.NET Web Pages (razor)  2011
ASP.NET SignalR    2012
ASP.NET Web API    2012

ASP.NET Core 1.0   2016

--------------------------------------------






Razor (Web Pages)
Web Forms
MVC

JavaScript (client)
Javascript AJAX (serveur)



-----------------------------------------------


Mod�le de programmation 

R�gles de Routage Transforment des URL vers des appels
---   Controller (classe)
---   Action     (m�thode)
 








2 engins de vues
Vues Razor (cshtml et vbhtml)
Vues ASPX  (aspx et ascx)

Par des tiers partis 
nhaml
etc

--------------------------------------


# MVC  

1. routage: 
  a. d�cortique le url d'apr�s les r�gles de routage
  b. il obtient le "controller" et l'"action".
2. MVC instancie le controller
3. MVC d�tecte quelle est l'action et sa m�thode attch�e
4. "Model binding" pr�pare les param�tres de la m�thodes.
    Il va chercher les valeurs des param�tres avec un mapping sur
    -queryString  -Param�tres Post -cookie -Route
5. On appelle la m�thode avec le bon param�tre.
----
6. La m�thode du controller instancie un Mod�le de donn�es.
7. Un mod�le peut �tre n'importe quel objet simple ou complexe
8. on cr�� une r�f�rence � un objet vue avec en param�tre le mod�le
-----
9. MVC instancie l'engin de Vue avec la vue retourn�e par la m�thode du controler
-----
10. L'engin razor g�n�re le html et �x�cute les commandes C# de la vue
    la vue poss�de du C# tr�s simple. 
-----
11. retourne les donn�es g�n�r�es par la vue au navigateur. 
12. On dispose du controller.


---------------------------------------------------------


Global.asax
- Application_Start

Startup.cs


----------------------------------------------------------
# Data

_ADO.NET_: ensemble de classes pour travailler avec les bases de donn�es.

_ADO.NET Providers_: Classes pour travailler avec des BD sp�cifiques.
         Connection
         DataReader
         Command
         Transaction
         etc

4 providers sont fournis par Microsoft
- SqlClient
- OleDb
- Odbc
- Oracle*  8

Plusieurs autres providers sont fournis par Tiers Partis 
   (MySql, Oracle, Db2, Postgre, etc.)

- ADO.NET disconnected classes: simule une BD en objet
   - DataSet
   - DataTables
   - DataRows
   - DataColumns
   - Constraints

------------------------------------------------------

# Entity Framework

Entity Framework : Ensemble de classes qui permet de s�rialiser
                   nos donn�es en Orient� Objet � travers du mapping

Il y a deux fa�ons de cr�er le mapping:
- Mod�le xml de nos entit�s. (vieille fa�on)
- avec du code c#. (code first) (nouvelle fa�on, compatible avec .NET Core)


Pour aller chercher des donn�es, on utilise des objets IQueryable
(Compatibles avec LINQ.) Cela g�n�re des requ�tes SQL qui ne sont pas 
toujours optimales. 


-Eager loading: utiliser une m�thode include pour aller chercher
des donn�es suppl�mentaires dans un join

-Lazy Loading:  On se connecte sur la BD au moment de travailler avec
les donn�es suppl�mentaires. Mauvais dans une boucle.

-----------

Il est possible pour EF de g�n�rer des entit�es � partir d'une BD.
Il est possible pour EF de g�n�rer une BD � partir d'entit�es


Entit�e: classe qui repr�sente un enregistrement d'une table. 


---------------

Il y a deux fa�ons de d�crire nos entit�es: Explicitement (attributs ou du Fluent API) ou implicitement (Conventions).

----------------------------------------------

Migration:  Technologie qui permet de synchroniser 
le sch�ma de BD avec les entit�s d'un dbcontext du projet.


Ligne de commande powershell pour cr�er les migration.

� chaque migration de cr��e, on ajoute une classe au projet.

Pour activer les migrations, il faut utiliser 3 commandes:

Enable-Migration: Cr�er la classe Configuration. Possiblement une migration initiale si la BD contient une table History.

Add-Migration 'nom migration': Cr�er une migration. Poss�de deux m�thodes:
'Up' permet d'ajouter des structures et 'Down' permet de r�gresser ces structures.

Update-Database : Permettre � une Bd de se mettre-�-jour ou de r�gresser.
Il est possible de Mettre-�-jour en direct, ou de g�n�rer un script SQL.



----------------

CSS: Cascading Style Sheet.

Cela d�finit un ensemble de r�gles pour formatter des �l�ments

On indique un s�lecteur sur lequel on place les r�gles.
ex: 
- Nom d'�l�ment (p, h1)
- Classe  (.classe .vert)
- id    (#bouton #txtnom)

On peut combiner les s�lecteurs.

On d�finit un enseble de r�gle pour checun des s�lecteur.
propri�t�: valeur

Le plus difficile, c'est l'ordre dans lequel les r�gles son appliqu�es. Il y a une m�thode dans lequel les r�gles sont appilqu�es. (plus sp�cifique)

---------------

# Bootstrap

Une librairie CSS qui permet de formatter la plupart des sites web dans un look propre, responsive, con�u pour les mobiles.


---------------------


Web API:  Technologie d'invocation � distance qui "remplace" WCF.  

Choses uniques � WCF: Transactions, Resilience, Message Queuing, custom Encryption, message Encryption, federated authentication

Web API:  Encrypt� HTTPS, identit� g�r�es par des headers OAuth


Messages qui utilisent HTTP + Approche REST + JSON

REST: Un URL repr�sente une ressource que l'on travaille avec un verbe HTTP
GET     Read
POST    Add
PUT     Update
DELETE  Delete
PATCH   Update Partiel
HEAD
OPTION

JSON: Format de donn�es Similaire � XML, 
      plus petit, plus simple, compatible avec Javascript



	  https://downloads.cdn.telerik.com/2d31863be6ea2629f01d7b7c5b1819f9_telerik.kendoui.professional.2017.1.223.trial.zip_2017.1.223?Expires=1490454081&Signature=sA~IK-RPqkoMhpPHcmUYLWchnHzmaiYSJCqZcjmfW1IDGlRJyCr3um1abSGNBKNommnQiLPleINyn-pKYhpi7gbmAhQ1F~BLoDg8Inz8rrVPUwIsl65lp1HtOeZzrS2SWjzsvQZk1m0cXJh1TjeCe1I7Au96r5hwmg6FlQMjli2DT7uWyOROZDOsBhZuxf5OD~o1eDGks8LZQxr4l8-7q2DBfcGNb5ekgiPIQLzBLu2umjyqtdAvvrmiFnBI7vXL~MtRUl~6vTDcXX-xQsYcqeuFqabB1b86WmGNoKzyNx1YNFRjUGekznwUgVFafyGjI2uhs3z2~Su-ujFvJuJV5g__&Key-Pair-Id=APKAJILH73OFECZJOO3Q




    





