# Documentation MVC

### .NET Framework: 
#### Composé de 2 choses: 
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

2.  Environnement d'éxécution (Runtime)
CLR   (Common Language Runtime)
- Load Library
- Gestion mémoire (garbage collection)
- JIT Compiler (Just in time)
- interop
- Thread
- Exception
- Type safety
- Securité
- Base Class Library (BCL)
- etc



----------------
<table>
<tr>
	<td>1.0</td><td>2002</td><td>Lib + CLR</td>
 </tr>
<tr>
	<td>1.1</td><td>2003</td><td>Lib + CLR</td>
 </tr>
 <tr>
	<td>2.0</td><td>2005</td><td>Lib + CLR</td>
 </tr>
 <tr>
	<td>3.0</td><td>2006</td><td>Lib</td>
 </tr>
 <tr>
	<td>3.5</td><td>2008</td><td>Lib</td>
 </tr>
 <tr>
	<td>4.0</td><td>2010</td><td>Lib + CLR (écrase 4.0)</td>
 </tr><tr>
	<td>4.5</td><td>2012</td><td>Lib + CLR (écrase 4.0)</td>
 </tr>
 <tr>
	<td>4.51</td><td>2013</td><td>Lib + CLR (écrase 4.0)</td>
 </tr>
 <tr>
	<td>4.6</td><td>2015</td><td>Lib + CLR (écrase 4.0)</td>
 </tr>
 <tr>
	<td>4.7</td><td>2017</td><td>Lib + CLR (écrase 4.0)</td>
 </tr>
 
</table>



# .NET Framework Core 1.0   
- CLR réinventé  2016
- Cross-platform (Windows, Mac, Linux, RasberryPi)
- Modulaire
- Open Source 
MAIS
- limité library
- VS2017  et plus

<table>
<tr>
	<td>1.0</td><td>2016</td>
 </tr>

<tr>
	<td>1.1</td><td>2016</td>
</tr>
<tr>
	<td>2.0</td><td>2017</td>
</tr>
</table>


-------

# ASP.NET Core 1.0 
Inclut MVC, Razor, Web Api, SignalR... MAIS pas de WebForms


-------------------------------------------


<table>
<tr>
	<td>ASP </td><td>1996</td><td>Basé sur VbScript</td>
 </tr>
 <tr>
	<td>ASP.NET WebForms</td><td>2002</td><td>Basé sur .NET, Abstraction Windows</td>
 </tr>
 <tr>
	<td>ASP.NET MVC </td><td>2009</td><td>Basé sur .NET, Abstraction Web</td>
 </tr><tr>
	<td>ASP.NET WebPages (Razor) </td><td>2011</td><td>Syntaxe de markup simplifiée</td>
 </tr><tr>
	<td>ASP.NET Web API </td><td>2012</td><td>Remplace Web Services / WCF</td>
 </tr><tr>
	<td>ASP.NET Signal R </td><td>2013</td><td>Notifications</td>
 </tr>
 <tr>
	<td>ASP.NET Core 1.0  </td><td>2016</td><td>Compatible .NET Famework Core</td>
 </tr>
 </Table>

-----------------------------------------------


#### Modèle de programmation 

Règles de Routage Transforment des URL vers des appels
- Controller (classe)
- Action     (méthode)
 
Le rôle de l'action est d'instancier un modèle et de l'attacher à une vue. 

--------------------------------



2 engins de vues
- Vues Razor (cshtml et vbhtml)
- Vues ASPX  (aspx et ascx)

Par des tiers partis 
- nhaml
- etc

--------------------------------------


# MVC  

1. routage: 
  a. décortique le url d'après les règles de routage
  b. il obtient le "controller" et l'"action".
2. MVC instancie le controller
3. MVC détecte quelle est l'action et sa méthode attchée
4. "Model binding" prépare les paramètres de la méthodes.
    Il va chercher les valeurs des paramètres avec un mapping sur
    -queryString  -Paramètres Post -cookie -Route
5. On appelle la méthode avec le bon paramètre.
----
6. La méthode du controller instancie un Modèle de données.
7. Un modèle peut être n'importe quel objet simple ou complexe
8. on créé une référence à un objet vue avec en paramètre le modèle
-----
9. MVC instancie l'engin de Vue avec la vue retournée par la méthode du controler
-----
10. L'engin razor génère le html et éxécute les commandes C# de la vue
    la vue possède du C# très simple. 
-----
11. retourne les données générées par la vue au navigateur. 
12. On dispose du controller.


---------------------------------------------------------


#### Global.asax
- Application_Start

#### Startup.cs


----------------------------------------------------------
# Data

_ADO.NET_: ensemble de classes pour travailler avec les bases de données.

_ADO.NET Providers_: Classes pour travailler avec des BD spécifiques.
         Connection
         DataReader
         Command
         Transaction
         etc

4 providers sont fournis par Microsoft
- SqlClient
- OleDb
- Odbc
- Oracle*  

Plusieurs autres providers sont fournis par Tiers Partis 
   (MySql, Oracle, Db2, Postgre, etc.)

- ADO.NET disconnected classes: simule une BD en objet (à éviter)
   - DataSet   - DataTables
   - DataRows
   - DataColumns
   - Constraints

------------------------------------------------------

# Entity Framework

Entity Framework : Ensemble de classes qui permet de sérialiser
                   nos données en Orienté Objet à travers du mapping
Il y a deux façons de créer le mapping:
- Modèle xml de nos entités. (fichier EDMX, vieille façon)
- avec du code c#. (code first) (nouvelle façon, compatible avec .NET Core)

Pour aller chercher des données, on utilise des objets IQueryable
(Compatibles avec LINQ.) Cela génère des requêtes SQL qui ne sont pas 
toujours optimales. 

- Eager loading: utiliser une méthode include pour aller chercher
des données supplémentaires dans un join
- Lazy Loading:  On se connecte sur la BD au moment de travailler avec
les données supplémentaires. Mauvais dans une boucle.

-----------

Il est possible pour EF de générer des entitées à partir d'une BD.
Il est possible pour EF de générer une BD à partir d'entitées


Entitée: classe qui représente un enregistrement d'une table. 

---------------

Il y a deux façons de décrire nos entitées: Explicitement (attributs ou du Fluent API) ou implicitement (Conventions).

----------------------------------------------

Migration:  Technologie qui permet de synchroniser 
le schéma de BD avec les entités d'un dbcontext du projet.
On utilise une ligne de commande powershell pour créer les migration.

À chaque migration de créée, on ajoute une classe au projet.

Pour activer les migrations, il faut utiliser 3 commandes:

`Enable-Migration` : Créer la classe Configuration. Possiblement une migration initiale si la BD contient une table History.

`Add-Migration 'nom migration'` : Créer une migration. La classe générée possède deux méthodes:
'Up' permet d'ajouter des structures et 'Down' permet de régresser ces structures.

`Update-Database` : Permettre à une Bd de se mettre-à-jour ou de régresser.
Il est possible de Mettre-à-jour en direct, ou de générer un script SQL.


----------------

# CSS: Cascading Style Sheet

Cela définit un ensemble de règles pour formatter des éléments

On indique un sélecteur sur lequel on place les règles. (il y en 3 types)
ex: 
- Nom d'élément (p, h1)
- Classe  (.classe .vert)
- id    (#bouton #txtnom)

On peut combiner les sélecteurs, ce qui complexifie grandement les règles.

On définit un ensemble de règles pour chacun des sélecteur.
`propriété: valeur`

Le plus difficile, c'est l'ordre dans lequel les règles sont appliquées. Il y a une méthodologie pour appliquer les règles. https://en.wikipedia.org/wiki/Cascading_Style_Sheets

---------------

# Bootstrap

Une librairie CSS qui permet de formatter la plupart des sites web dans un look propre, responsive, conçu pour les mobiles.


---------------------


**Web API**:  Technologie d'invocation à distance qui "remplace" WCF.  

**Choses uniques à WCF**: Transactions, Resilience, Message Queuing, custom Encryption, message Encryption, federated authentication

**Web API**:  Encrypté HTTPS, identité gérées par des headers OAuth

Messages utilisent HTTP + Approche REST + JSON

**REST**: Un URL représente une ressource que l'on travaille avec un verbe HTTP
- GET     Read
- POST    Add
- PUT     Update
- DELETE  Delete
- PATCH   Update Partiel
- HEAD
- OPTION

**JSON**: Format de données Similaire à XML, plus petit, plus simple, compatible avec Javascript
