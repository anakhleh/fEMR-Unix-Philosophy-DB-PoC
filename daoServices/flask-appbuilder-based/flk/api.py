from flask_appbuilder import ModelRestApi
from flask_appbuilder.models.sqla.interface import SQLAInterface

from . import appbuilder, db
from .models import Subject, Subjectinfo

db.create_all()

class SubjectModelApi(ModelRestApi):
    resource_name = 'subject'
    datamodel = SQLAInterface(Subject)

class SubjectInfoModelApi(ModelRestApi):
    resource_name = 'subjectinfo'
    datamodel = SQLAInterface(Subjectinfo)


appbuilder.add_api(SubjectModelApi)
appbuilder.add_api(SubjectInfoModelApi)