DuckDuckGo Search API
============

DuckDuckGo Search is a simple tool for searching DuckDuckGo. It returns the search results from DuckDuckGo.

![Build Status](https://img.shields.io/badge/build-passing-green)
![Code Climate](https://img.shields.io/badge/maintainability-B-purple)
![Prod Ready](https://img.shields.io/badge/production-ready-blue)

This is a .NET Wrapper for the [DuckDuckGo Search API](https://apiverve.com/marketplace/api/duckduckgosearch)

---

## Installation

Using the .NET CLI:
```
dotnet add package APIVerve.API.DuckDuckGoSearch
```

Using the Package Manager:
```
nuget install APIVerve.API.DuckDuckGoSearch
```

Using the Package Manager Console:
```
Install-Package APIVerve.API.DuckDuckGoSearch
```

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on Manage NuGet Packages...
4. Click on the Browse tab and search for "APIVerve.API.DuckDuckGoSearch".
5. Click on the APIVerve.API.DuckDuckGoSearch package, select the appropriate version in the right-tab and click Install.


---

## Configuration

Before using the duckduckgosearch API client, you have to setup your account and obtain your API Key.  
You can get it by signing up at [https://apiverve.com](https://apiverve.com)

---

## Usage

The DuckDuckGo Search API documentation is found here: [https://docs.apiverve.com/api/duckduckgosearch](https://docs.apiverve.com/api/duckduckgosearch).  
You can find parameters, example responses, and status codes documented here.

### Setup

###### Authentication
DuckDuckGo Search API uses API Key-based authentication. When you create an instance of the API client, you can pass your API Key as a parameter.

```
// Create an instance of the API client
var apiClient = new DuckDuckGoSearchAPIClient("[YOUR_API_KEY]", true);
```

---


### Perform Request
Using the API client, you can perform requests to the API.

###### Define Query

```
var queryOptions = new duckduckgosearchQueryOptions {
  query = "computer science"
};
```

###### Simple Request

```
var response = apiClient.Execute(queryOptions);
if(response.error != null) {
	Console.WriteLine(response.error);
} else {
    var jsonResponse = JsonConvert.SerializeObject(response, Newtonsoft.Json.Formatting.Indented);
    Console.WriteLine(jsonResponse);
}
```

###### Example Response

```
{
  "status": "ok",
  "error": null,
  "data": {
    "query": "computer science",
    "count": 23,
    "results": [
      {
        "title": "Computer science - Wikipedia",
        "url": "https://en.wikipedia.org/wiki/Computer_science",
        "description": "Computer science. Computer science is the study of computation, information, and automation. [1] [2] [3] Computer science spans theoretical disciplines (such as algorithms, theory of computation, and information theory) to applied disciplines (including the design and implementation of hardware and software )."
      },
      {
        "title": "What Is Computer Science? Meaning, Jobs, and Degrees",
        "url": "https://www.coursera.org/articles/what-is-computer-science",
        "description": "Learn what computer science is, how it's used in various industries, and what careers you can pursue with a degree in this field. Explore the subfields, skills, salaries, and outlook of computer science jobs."
      },
      {
        "title": "What is Computer Science? - Codecademy",
        "url": "https://www.codecademy.com/resources/blog/what-is-computer-science/",
        "description": "Learn what computer science is, why it's important, and how to get started. Explore various roles in the field, from front-end and back-end engineering to data science and cybersecurity, and find out how to prepare with courses and projects."
      },
      {
        "title": "Computer science | Definition, Types, &amp; Facts | Britannica",
        "url": "https://www.britannica.com/science/computer-science",
        "description": "Learn about the study of computers and computing, including their theoretical and algorithmic foundations, hardware and software, and their uses for processing information. Explore the history, subfields, and applications of computer science, as well as its interdisciplinary connections with other fields."
      },
      {
        "title": "CS50: Introduction to Computer Science | Harvard Online Course",
        "url": "https://www.harvardonline.harvard.edu/course/cs50-introduction-computer-science",
        "description": "Learn the basics of computer science and programming in C, Python, SQL, and JavaScript with CS50x, Harvard's largest course. This self-paced course is open to all levels of experience and offers a certificate for a passing grade."
      },
      {
        "title": "CS50: Introduction to Computer Science | Harvard University",
        "url": "https://pll.harvard.edu/course/cs50-introduction-computer-science",
        "description": "Learn the basics of computer science and programming with CS50x, a self-paced online course from Harvard. Explore topics like algorithms, data structures, web development, and more with C, Python, SQL, and JavaScript."
      },
      {
        "title": "HarvardX: CS50&#x27;s Introduction to Computer Science | edX",
        "url": "https://www.edx.org/learn/computer-science/harvard-university-cs50-s-introduction-to-computer-science",
        "description": "Learn the basics of computer science and programming with C, Python, SQL, and JavaScript plus CSS and HTML. This self-paced course is for beginners and majors, and offers a certificate for satisfactory performance on problem sets and a final project."
      },
      {
        "title": "CS50: Computer Science Courses and Programs from Harvard",
        "url": "https://www.edx.org/cs50",
        "description": "Learn computer science, mobile app and game development, business technologies, and the art of programming with CS50, the largest course on the Harvard campus. Explore introductory CS50 courses and Professional Certificate programs from Harvard that are open to learners of all backgrounds."
      },
      {
        "title": "Harvard CS50 - Full Computer Science University Course",
        "url": "https://www.youtube.com/watch?v=8mAITcNt710",
        "description": "Learn the basics of computer science from Harvard University. This is CS50, an introduction to the intellectual enterprises of computer science and the art o..."
      },
      {
        "title": "Computer science theory | Computing | Khan Academy",
        "url": "https://www.khanacademy.org/computing/computer-science",
        "description": "Learn select topics from computer science, such as algorithms, cryptography, and information theory, with interactive exercises and videos. Explore the history and applications of these concepts in various fields and contexts."
      },
      {
        "title": "Computer Science - Harvard University",
        "url": "https://www.harvard.edu/programs/computer-science/",
        "description": "The concentration in Computer Science is designed to teach students skills and ideas they will use immediately and in the future. Because information technology affects every aspect of society, graduates with computer science degrees have open to them an enormous variety of careers—engineering, teaching, medicine, law, basic science, entertainment, management, and countless others."
      },
      {
        "title": "Computer science - Latest research and news | Nature",
        "url": "https://www.nature.com/subjects/computer-science",
        "description": "Computer science is the study and development of the protocols required for automated processing and manipulation of data. This includes, for example, creating algorithms for efficiently searching ..."
      },
      {
        "title": "Best Online Computer Science Courses and Programs - edX",
        "url": "https://www.edx.org/learn/computer-science",
        "description": "Learn computer science with online courses and programs from top universities on edX. Explore topics such as algorithms, artificial intelligence, data science, and more."
      },
      {
        "title": "Code a New Career | ComputerScience.org",
        "url": "https://www.computerscience.org/",
        "description": "Once you've earned this computer science degree, you'll be ready to apply your knowledge and skills to design, develop, and optimize systems that can meet current and future industry needs. Take a hands-on, scientific approach to IT. Learn programming languages and architecture along with theory, application, & ethics."
      },
      {
        "title": "Best Computer Science Courses Online [2024] | Coursera",
        "url": "https://www.coursera.org/browse/computer-science",
        "description": "Explore the best online courses and degrees in computer science from top universities and institutions. Learn programming, data analytics, cybersecurity, AI, and more with Coursera."
      },
      {
        "title": "What is Computer Science? | School of Computer Science",
        "url": "https://www.scs.gatech.edu/what-computer-science",
        "description": "Georgia Tech's School of Computer Science is home to a group of faculty and researchers with breadth and strength in all aspects of the computational process—from the algorithms to the architecture, from theory to networking, from system design to the programming environments to databases. At Georgia Tech, we make computing better, now and ..."
      },
      {
        "title": "What to Know About Becoming a Computer Science Major",
        "url": "https://www.usnews.com/education/best-colleges/computer-science-major-overview",
        "description": "Computer science is a major for problem-solving students who want to learn how to use computers and computational processes to build websites, program robots, mine data and more."
      },
      {
        "title": "Computer Science Guide | BestColleges",
        "url": "https://www.bestcolleges.com/computer-science/what-is-computer-science/",
        "description": "Learn what computer science is, what skills are needed, and what careers are available in this field. Find out the job demand, salary, and specializations for computer science professionals."
      },
      {
        "title": "Computing | Khan Academy",
        "url": "https://www.khanacademy.org/computing",
        "description": "Explore various topics in computing, from programming languages and web development to algorithms and data structures. Learn with interactive lessons, videos, exercises and projects on Khan Academy."
      },
      {
        "title": "What is Computer Science? | Undergraduate Computer Science at UMD",
        "url": "https://undergrad.cs.umd.edu/what-computer-science",
        "description": "Computer Science is the study of computers and computational systems, including their theory, design, development, and application. Learn about the principal areas of Computer Science, such as artificial intelligence, security, database systems, and more."
      },
      {
        "title": "Computer Science | Harvard John A. Paulson School of Engineering and ...",
        "url": "https://seas.harvard.edu/computer-science",
        "description": "Learn about the computer science program at Harvard John A. Paulson School of Engineering and Applied Sciences. Explore the areas of study, interdisciplinary initiatives, and leadership of the department."
      },
      {
        "title": "Computer Science - MIT EECS - Massachusetts Institute of Technology",
        "url": "https://www.eecs.mit.edu/research/computer-science/",
        "description": "Explore the subareas of computer science, from theory to systems to human-computer interaction, and how they drive interdisciplinary collaboration at MIT. Learn about the latest news and events in this field, from AI for healthcare to quantum computing."
      },
      {
        "title": "What is Computer Science? | Michigan Technological University",
        "url": "https://www.mtu.edu/cs/what/",
        "description": "Learn about computer science as a broad and innovative field that includes software, hardware, and human-computer interaction. Explore the career opportunities, skills, and research in computer science at Michigan Tech, a leading college in computing education."
      }
    ]
  }
}
```

---

## Customer Support

Need any assistance? [Get in touch with Customer Support](https://apiverve.com/contact).

---

## Updates
Stay up to date by following [@apiverveHQ](https://twitter.com/apiverveHQ) on Twitter.

---

## Legal

All usage of the APIVerve website, API, and services is subject to the [APIVerve Terms of Service](https://apiverve.com/terms) and all legal documents and agreements.

---

## License
Licensed under the The MIT License (MIT)

Copyright (&copy;) 2024 APIVerve, and Evlar LLC

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.