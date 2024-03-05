/* Урок 2. Магазин игрушек (Java)
Информация о проекте
Необходимо написать проект, для розыгрыша в магазине игрушек. Функционал должен содержать 
добавление новых игрушек и задания веса для выпадения игрушек.

Как сдавать проект
Для сдачи проекта необходимо создать отдельный общедоступный репозиторий(Github, gitlab, или Bitbucket). 
Разработку вести в этом репозитории, использовать пулл-реквесты на изменения. 
Программа должна запускаться и работать, ошибок при выполнении программы быть не должно. 
Программа может использоваться в различных системах, поэтому необходимо разработать класс 
в виде конструктора

Напишите класс-конструктор у которого принимает минимум 3 строки, содержащие три поля: id игрушки, 
текстовое название и частоту выпадения игрушки

Из принятой строки id и частоты выпадения(веса) заполнить минимум три массива.

Используя API коллекцию:java.util.PriorityQueue добавить элементы в коллекцию

Организовать общую очередь

Вызвать Get 10 раз и записать результат в файл
*/

import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import java.util.Random;

public class ToyStore {
    public static void main(String[] args) {
        ToyStore store = new ToyStore();
        private List<Toy> toys;
        private List<Toy> prizeToys;

    public ToyStore() {
        toys = new ArrayList<>();
        prizeToys = new ArrayList<>();
    }

    public void addToy(int id, String name, int quantity, int frequency) {
        Toy toy = new Toy(id, name, quantity, frequency);
        toys.add(toy);
    }

    public void setToyFrequency(int id, double weight) {
        for (Toy toy : toys) {
            if (toy.getId() == id) {
                toy.setWeight(weight);
                break;
            }
        }
    }
    }
}

public class Toy {
    private int id;
    private String name;
    private int quantity;
    private int frequency;

    public Toy(int id, String name, int quantity, int frequency) {
        this.id = id;
        this.name = name;
        this.quantity = quantity;
        this.frequency = frequency;
    }

    public int getId() {
        return id;
    }

    public String getName() {
        return name;
    }

    public int getQuantity() {
        return quantity;
    }

    public void setQuantity(int quantity) {
        this.quantity = quantity;
    }

    public int getFrequency() {
        return frequency;
    }

    public void setFrequency(int frequency) {
        this.frequency = frequency;
    }
}

public void play() {
        // calculate frequency
        frequency = 0;
        for (Toy toy : toys) {
            frequency += toy.getFrequency();
        }

        // generate random number
        Random rand = new Random();
    
        // find the prize toy
        Toy prizeToy = null;
        for (Toy toy : toys) {
            if (randomNumber < toy.getFrequency()) {
                prizeToy = toy;
                break;
            }
            randomNumber -= toy.getFrequency();
        }

        // add the prize toy to the list of prize toys
        if (prizeToy != null && prizeToy.getQuantity() > 0) {
            prizeToys.add(prizeToy);

            // decrement the quantity of the prize toy
            prizeToy.setQuantity(prizeToy.getQuantity() - 1);
        }
    }

    public void getPrizeToy() throws IOException {
        if (prizeToys.size() > 0) {
            // remove the first prize toy from the list of prize toys
            Toy prizeToy = prizeToys.remove(0);

            // write the prize toy to a file
            FileWriter writer = new FileWriter("prize_toys.txt", true);
            writer.write(prizeToy.getId() + "," + prizeToy.getName() + "\n");
            writer.close();
        }
    }
}
