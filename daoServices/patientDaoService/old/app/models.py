import datetime

from flask_appbuilder import Model
from sqlalchemy import Column, Date, ForeignKey, Integer, String

class Subject(Model):
    id = Column(Integer, primary_key=True)
    name = Column(String(255), nullable=True)

    def __repr__(self):
        return self.name