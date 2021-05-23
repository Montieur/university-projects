from django.db import models
from django.contrib.auth.models import User
from django.db.models.fields.related import ForeignKey

# Create your models here.

class Section(models.Model):
    id = models.AutoField(primary_key=True)
    sortOrder = models.IntegerField()
    name = models.CharField(max_length=64)
    description = models.CharField(max_length=128, default='')
    def __str__(self):
        return ('(%i) %s' % (self.id, self.name))

class Thread(models.Model):
    id = models.AutoField(primary_key=True)
    section = models.ForeignKey(Section, on_delete=models.CASCADE)
    title = models.CharField(max_length=128)
    content = models.TextField()
    author = models.ForeignKey(User, on_delete=models.DO_NOTHING)
    def __str__(self):
        return ('(%i) %s / %s' % (self.id, self.section.name, self.title))

class Reply(models.Model):
    id = models.AutoField(primary_key=True)
    thread = models.ForeignKey(Thread, on_delete=models.CASCADE)
    content = models.TextField()
    author = models.ForeignKey(User, on_delete=models.DO_NOTHING)
    def __str__(self):
        return ('(%i) %s / %s' % (self.id, self.author, self.thread.title))