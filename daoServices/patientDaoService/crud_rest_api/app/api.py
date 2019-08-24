from flask_appbuilder import ModelRestApi
from flask_appbuilder.models.sqla.interface import SQLAInterface

from . import appbuilder, db
from .models import Subject

db.create_all()

class SubjectModelApi(ModelRestApi):
    resource_name = 'subject'
    datamodel = SQLAInterface(Subject)

appbuilder.add_api(SubjectModelApi)
