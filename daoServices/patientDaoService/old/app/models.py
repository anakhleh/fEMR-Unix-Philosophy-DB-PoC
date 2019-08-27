from flask_sqlalchemy import SQLAlchemy

db = SQLAlchemy(app)

class Subject(db.Model):
    id = Column(Integer, primary_key=True)
    name = Column(String(255), nullable=True)

    def __repr__(self):
        return self.name