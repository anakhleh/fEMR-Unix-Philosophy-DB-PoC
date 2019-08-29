from flask_appbuilder import ModelRestApi
from flask_appbuilder.models.sqla.interface import SQLAInterface

from . import appbuilder, db
from .models import Subject, Subjectinfo

db.create_all()

#list_columns
#add_columns
#edit_columns

class SubjectModelApi(ModelRestApi):
    resource_name = 'subject'
    list_columns = ['id', 'name']
    add_columns = ['name']
    datamodel = SQLAInterface(Subject)

class SubjectInfoModelApi(ModelRestApi):
    resource_name = 'subjectinfo'
    list_columns = ['id', 'subject_id', 'info']
    add_columns = ['subject_id', 'info']
    datamodel = SQLAInterface(Subjectinfo)


appbuilder.add_api(SubjectModelApi)
appbuilder.add_api(SubjectInfoModelApi)