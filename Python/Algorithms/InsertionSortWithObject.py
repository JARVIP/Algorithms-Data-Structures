

class Person:

    def __init__(self, name, age):
        self.name = name
        self.age = age

    def __lt__(self, other):
        return self.age < other.age

    def __repr__(self):
        return str(self.name)


def sort_people(people):
    for i in range(len(people)):
        j = i

        while j > 0 and people[j - 1] > people[j]:
            people[j], people[j - 1] = people[j - 1], people[j]
            j = j - 1


if __name__ == "__main__":
    n = [Person("oleg", 24), Person("gvantsa", 23), Person("levan", 31), Person("nika", 26), Person("temo", 32), Person("ana", 24)]
    sort_people(n)
    print(n)
