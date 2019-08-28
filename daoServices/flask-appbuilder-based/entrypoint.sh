#Make sure that postgres is up and running before starting the servver
while !</dev/tcp/db/5432;
do sleep 1;
done;
ls | echo

flask fab create-admin;
flask run -h "$FLASK_SERVER_HOST" -p "$FLASK_RUN_PORT";