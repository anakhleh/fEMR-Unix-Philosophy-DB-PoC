import datetime

from flask_appbuilder import Model
from sqlalchemy import Column, Date, ForeignKey, Integer, String, Text
from sqlalchemy.orm import relationship

mindate = datetime.date(datetime.MINYEAR, 1, 1)

class Subject(Model):
    id = Column(Integer, primary_key=True)
    name = Column(String(150), unique=True, nullable=False)

    def __repr__(self):
        return self.name

class Subjectinfo(Model):
    id = Column(Integer, primary_key=True)
    subject_id = Column(Integer, ForeignKey(Subject.id), nullable=False)
    info = Column(Text, nullable=False)

    def __repr__(self):
        return self.name
