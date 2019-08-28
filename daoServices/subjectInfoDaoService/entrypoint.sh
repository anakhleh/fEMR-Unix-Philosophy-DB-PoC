#Make sure postgres is up
while !</dev/tcp/db/5432;
do sleep 1;
done;

#Make sure subject dao service is up
while true
do
    STATUS=$(curl -s -o /dev/null -w '%{http_code}' http://"$SUBJECT_DAO_SERVICE_HOST_AND_PORT"/subject)
    if [ $STATUS -eq 200 ]; then
    echo "SubjectDaoService is up"
        break
    else
        echo "Got $STATUS :( Not done yet..."
    fi
    sleep 1;
done;

#Run App
python app.py;