from django.http.request import HttpRequest
from django.shortcuts import render, HttpResponse, redirect
from .models import Section, Thread, Reply
from .forms import RegisterForm, ReplyForm, ThreadForm
import operator

# Create your views here.

def homepage(request):
    sections = Section.objects.all()
    sections = list(sections)
    sections.sort(key=operator.attrgetter('sortOrder'))

    return render(request, 'index.html', {
        'sections': sections,
    })

def sectionpage(request, sectionName):

    section = Section.objects.get(name = sectionName)

    if request.method == 'POST':
        form = ThreadForm(request.POST)
        if form.is_valid():
            author = request.user
            title = form.cleaned_data['title']
            content = form.cleaned_data['content']
            thread = Thread(section=section, title=title, content=content, author=author)
            thread.save()

    threads = Thread.objects.filter(section=section)

    return render(request, 'section.html', {
        'section': section,
        'threads': threads,
    })

def threadpage(request, sectionName, threadId):
    section = Section.objects.get(name = sectionName)
    thread = Thread.objects.get(id = threadId)

    if request.method == 'POST':
        form = ReplyForm(request.POST)
        if form.is_valid():
            if request.user.is_authenticated:
                userName = request.user
                content = form.cleaned_data['content']
                reply = Reply(thread=thread, content=content, author=userName)
                reply.save()

    replies = Reply.objects.filter(thread=thread)

    form = None
    if request.user.is_authenticated:
        form = ReplyForm()

    return render(request, 'thread.html', {
        'section': section,
        'thread': thread,
        'replies': replies,
        'replyform': form,
    })

def makethreadpage(request, sectionName):
    section = Section.objects.get(name = sectionName)

    threadForm = ThreadForm()

    return render(request, 'newthread.html', {
        'section': section,
        'threadForm': threadForm,
    })

def editreply(request, replyId):
    reply = Reply.objects.get(id=replyId)
    thread = reply.thread
    section = thread.section.name
    if request.user == reply.author:
        if request.method == 'POST':
            form = ReplyForm(request.POST)
            if form.is_valid():
                reply.content = form.cleaned_data['content']
                reply.save()
                return redirect('threadpage', section, reply.thread.id)
            return HttpRequest("Błąd")
        else:
            form = ReplyForm(initial={
                'content': reply.content
            })
            return render(request, 'edit.html', {
                'form': form,
                'reply': reply
                })
    return redirect('/accounts/login')

def editthread(request, threadId):
    thread = Thread.objects.get(id=threadId)
    section = thread.section.name
    if request.user == thread.author:
        if request.method == 'POST':
            form = ThreadForm(request.POST)
            if form.is_valid():
                thread.title = form.cleaned_data['title']
                thread.content = form.cleaned_data['content']
                thread.save()
                return redirect('threadpage', section, thread.id)
            return HttpRequest("Błąd")
        else:
            form = ThreadForm(initial={
                'title': thread.title,
                'content': thread.content
            })
            return render(request, 'editThread.html', {
                'form': form,
                'thread': thread
                })
    return redirect('/accounts/login')



def register(request):

    if request.method == "POST":
            form = RegisterForm(request.POST)
            if form.is_valid():
                form.save()
                return render(request,
                    'registration/success.html')
            else:
                errors = form.errors
                errorStr = 'Przy wysyłaniu formularza wystąpiły błędy:<ul>'
                for i in errors:
                    errorStr += '<li>%s</li>' % i
                errorStr += '</ul>'
                return render(request,
                    'registration/register.html',
                    {
                        'form': form,
                        'errors': errorStr,
                    })
    else:
        form = RegisterForm()
        return render(request, 
            'registration/register.html',
            {
                'form': form,
            })
