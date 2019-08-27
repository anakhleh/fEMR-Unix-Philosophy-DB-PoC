# fEMR-Unix-Philosophy-DB-PoC
This is a rambling piece. I write it as I think.

#Idea - Microservices you can't see from the api layer

#Application Plugin Levels and Guidelines
##On Microservices
Most of these microservices will look like they could just be simply imported into
a program. That's true. However, seperating the app into verious microservices basically
gives us some level of plugin functionality, and means that you don't touch pre-built modules.
That means that the low-level code stays clean, and that you don't need to worry about touching it

##General
The frontend JS/CSS/HTML client must be as stupid as possible.

####Lowest Level
The Lowest level plugin is a DAOplugin - ex, patientDaoPlugin. It is a microservice that interacts
with only a single entity. These must be as simple as possible.
These should never be written manually. Only the model specification may be human written.
All else must be generated. This is done so that so long as we trust the generator, we 
trust the code. After this generation, you don't touch it. It should allow config from outside
for a db connection string, and THAT IS IT. 

How to communicate with these guys? Generate an API client through swagger, use that to 
talk with the running service.

How to structure? Are these lower level guys just django apps? - I wouldn't really want so - 
that means they get included in your project? If it's just an import in a config, file, that's ok,
but if it's more than that, then no. That being said, being able to run all the services off 
one web server would be cool, but that kind of is not the point of a microservice, eh.

IDEA - It doesn't even really matter what we write this thing in - every plugin gets a docker
container, every plugin could contain several docker plugins. I like this idea. That way,
all you need to do to config is edit a docker-compose.yml or dockerfile.yml to select what plugins.
each plugin that requires plugins would have its own docker-compose or dockerfile.yml.

Each plugin then can become its own dev effort. A system could just run a bunch of docker
containers. And this system could just run in a vm somewhere.

Database could just run in one docker container, or it could be separated as necessary.

-- Alex

#Dev/Usage Info
camelCase must be used for everything.
All microservice ports run on ports starting at 9000 for the db

#Usage
Assuming you are in project folder:
`git update-index --assume-unchanged ./daoServices/subjectDaoService/dev-db.sqlite3`
