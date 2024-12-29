namespace AlgoDes6;

public partial class Form1 : Form
{
    List<Card> cards =
    [
        new Card(9, Suits.Clubs,
            "C:\\Users\\Ollika\\RiderProjects\\AlgoDes6\\AlgoDes6\\bin\\Debug\\net8.0-windows\\cards\\9_clubs.png"),
        new Card(10, Suits.Clubs,
            "C:\\Users\\Ollika\\RiderProjects\\AlgoDes6\\AlgoDes6\\bin\\Debug\\net8.0-windows\\cards\\10_clubs.png"),
        new Card(11, Suits.Clubs,
            "C:\\Users\\Ollika\\RiderProjects\\AlgoDes6\\AlgoDes6\\bin\\Debug\\net8.0-windows\\cards\\J_clubs.png"),
        new Card(12, Suits.Clubs,
            "C:\\Users\\Ollika\\RiderProjects\\AlgoDes6\\AlgoDes6\\bin\\Debug\\net8.0-windows\\cards\\Q_clubs.png"),
        new Card(13, Suits.Clubs,
            "C:\\Users\\Ollika\\RiderProjects\\AlgoDes6\\AlgoDes6\\bin\\Debug\\net8.0-windows\\cards\\K_clubs.png"),
        new Card(14, Suits.Clubs,
            "C:\\Users\\Ollika\\RiderProjects\\AlgoDes6\\AlgoDes6\\bin\\Debug\\net8.0-windows\\cards\\A_clubs.png"),
        new Card(9, Suits.Diamonds,
            "C:\\Users\\Ollika\\RiderProjects\\AlgoDes6\\AlgoDes6\\bin\\Debug\\net8.0-windows\\cards\\9_diamonds.png"),
        new Card(10, Suits.Diamonds,
            "C:\\Users\\Ollika\\RiderProjects\\AlgoDes6\\AlgoDes6\\bin\\Debug\\net8.0-windows\\cards\\10_diamonds.png"),
        new Card(11, Suits.Diamonds,
            "C:\\Users\\Ollika\\RiderProjects\\AlgoDes6\\AlgoDes6\\bin\\Debug\\net8.0-windows\\cards\\J_diamonds.png"),
        new Card(12, Suits.Diamonds,
            "C:\\Users\\Ollika\\RiderProjects\\AlgoDes6\\AlgoDes6\\bin\\Debug\\net8.0-windows\\cards\\Q_diamonds.png"),
        new Card(13, Suits.Diamonds,
            "C:\\Users\\Ollika\\RiderProjects\\AlgoDes6\\AlgoDes6\\bin\\Debug\\net8.0-windows\\cards\\K_diamonds.png"),
        new Card(14, Suits.Diamonds,
            "C:\\Users\\Ollika\\RiderProjects\\AlgoDes6\\AlgoDes6\\bin\\Debug\\net8.0-windows\\cards\\A_diamonds.png"),
        new Card(9, Suits.Hearts,
            "C:\\Users\\Ollika\\RiderProjects\\AlgoDes6\\AlgoDes6\\bin\\Debug\\net8.0-windows\\cards\\9_hearts.png"),
        new Card(10, Suits.Hearts,
            "C:\\Users\\Ollika\\RiderProjects\\AlgoDes6\\AlgoDes6\\bin\\Debug\\net8.0-windows\\cards\\10_hearts.png"),
        new Card(11, Suits.Hearts,
            "C:\\Users\\Ollika\\RiderProjects\\AlgoDes6\\AlgoDes6\\bin\\Debug\\net8.0-windows\\cards\\J_hearts.png"),
        new Card(12, Suits.Hearts,
            "C:\\Users\\Ollika\\RiderProjects\\AlgoDes6\\AlgoDes6\\bin\\Debug\\net8.0-windows\\cards\\Q_hearts.png"),
        new Card(13, Suits.Hearts,
            "C:\\Users\\Ollika\\RiderProjects\\AlgoDes6\\AlgoDes6\\bin\\Debug\\net8.0-windows\\cards\\K_hearts.png"),
        new Card(14, Suits.Hearts,
            "C:\\Users\\Ollika\\RiderProjects\\AlgoDes6\\AlgoDes6\\bin\\Debug\\net8.0-windows\\cards\\A_hearts.png"),
        new Card(9, Suits.Spades,
            "C:\\Users\\Ollika\\RiderProjects\\AlgoDes6\\AlgoDes6\\bin\\Debug\\net8.0-windows\\cards\\9_spades.png"),
        new Card(10, Suits.Spades,
            "C:\\Users\\Ollika\\RiderProjects\\AlgoDes6\\AlgoDes6\\bin\\Debug\\net8.0-windows\\cards\\10_spades.png"),
        new Card(11, Suits.Spades,
            "C:\\Users\\Ollika\\RiderProjects\\AlgoDes6\\AlgoDes6\\bin\\Debug\\net8.0-windows\\cards\\J_spades.png"),
        new Card(12, Suits.Spades,
            "C:\\Users\\Ollika\\RiderProjects\\AlgoDes6\\AlgoDes6\\bin\\Debug\\net8.0-windows\\cards\\Q_spades.png"),
        new Card(13, Suits.Spades,
            "C:\\Users\\Ollika\\RiderProjects\\AlgoDes6\\AlgoDes6\\bin\\Debug\\net8.0-windows\\cards\\K_spades.png"),
        new Card(14, Suits.Spades,
            "C:\\Users\\Ollika\\RiderProjects\\AlgoDes6\\AlgoDes6\\bin\\Debug\\net8.0-windows\\cards\\A_spades.png")
    ];

    private static Random rnd = new();
    private List<Card> playerCards = new();
    private Suits playerSuit;
    private Label turnLabel;
    private Panel playerCardsPanel = new Panel();
    private List<Card> opponentCards = new();
    private Suits opponentSuit;
    private bool isPlayerWon = false;

    private List<Card> tableCards = new List<Card>();
    private PictureBox selectedCard = null;

    private List<Card> cardsToToss = new();
    private List<Card> cardsToBeat = new();

    private Card opponentCardToToss;

    private int cardPair; // для зміни координат розташування карт

    private void PlayerMove()
    {
        (FindControl("takeCardsButton") as Button).Visible = false;
        (FindControl("beatenButton") as Button).Visible = true;

        tableCards.Clear();
        cardsToToss.Clear();
        cardsToBeat.Clear();

        cardPair = 0;
        foreach (Control control in playerCardsPanel.Controls)
        {
            if (control is PictureBox pictureBox)
            {
                pictureBox.Click += Card_To_Attack_Click; // Додаємо обробник події для картки
            }
        }
    }

    private bool CardRankInList(List<Card> cardsToCompare, Card cardToCompare)
    {
        return cardsToCompare.Any(card => card.Rank == cardToCompare.Rank);
    }
    
    private Card FindCard(string path)
    {
        foreach (Card card in cards)
        {
            if (card.ImagePath == path)
                return card;
        }

        return cards[0];
    }

    private void ShowCards()
    {
        if (playerCards.Count == 0)
        {
            MessageBox.Show("Ви перемогли!");
            return;
        }

        if (Controls.Contains(playerCardsPanel))
        {
            Controls.Remove(playerCardsPanel);
        }

        playerCardsPanel = new Panel
        {
            BackColor = Color.DarkTurquoise,
            Location = new Point(30, ClientSize.Height - 170),
            Size = new Size(658, 170),
            AutoScroll = true
        };

        Controls.Add(playerCardsPanel);

        int xOffset = 0;

        foreach (var card in playerCards)
        {
            // Завантажуємо зображення карти
            Image cardImage = Image.FromFile(card.ImagePath);

            // Створюємо PictureBox для кожної карти
            PictureBox pictureBox = new PictureBox
            {
                Image = cardImage,
                SizeMode = PictureBoxSizeMode.AutoSize, // Картинка відображається без зміни розміру
                Location = new Point(xOffset, 0),
                Tag = card.ImagePath // Зберігаємо шлях до файлу в Tag
            };

            playerCardsPanel.Controls.Add(pictureBox);
            xOffset += cardImage.Width + 10; // Відстань між картами
        }
    }

    private void Card_To_Attack_Click(object sender, EventArgs e)
    {
        if (cardPair == 5)
        {
            MessageBox.Show("Лише 5 карт можна кинути");
            return;
        }

        selectedCard = sender as PictureBox;
        if (selectedCard != null)
        {
            // Знаходимо картку, що відповідає цьому зображенню
            string imagePath = selectedCard.Tag as string;
            Card cardToToss = FindCard(imagePath);

            // Перевіряємо, чи карта можна кинути
            if (cardsToToss.Count == 0 ||
                CardRankInList(cardsToBeat, cardToToss) ||
                CardRankInList(cardsToToss, cardToToss))
            {
                // Якщо карта може бути кинута, переносимо її на стіл
                var targetLocation = cardPair < 3
                    ? new Point(500 - (170 * cardPair), 200)
                    : new Point(500 - (170 * (cardPair - 2)), 10);

                // Створюємо нову картку (копія) для додавання на форму
                PictureBox newCard = new PictureBox
                {
                    Image = selectedCard.Image,
                    SizeMode = PictureBoxSizeMode.AutoSize,
                    Location = targetLocation, // Встановлюємо координати
                    Tag = selectedCard.Tag // Копіюємо дані картки
                };

                // Додаємо нову картку на форму
                this.Controls.Add(newCard);

                // Переміщаємо нову картку на передній план
                newCard.BringToFront();

                // Видаляємо картку з панелі
                selectedCard.Parent.Controls.Remove(selectedCard);

                // Видаляємо картку з колекції playerCards
                playerCards.Remove(cardToToss);

                // Додаємо картку до списку tableCards
                tableCards.Add(cardToToss);

                // Додаємо картку до списку карт, що викидаються
                cardsToToss.Add(cardToToss);

                // Скидаємо вибір картки
                selectedCard.BorderStyle = BorderStyle.None;
                selectedCard = null; // Вибір картки скидається після переміщення

                // Після успішного ходу гравця викликаємо відповідь противника
                if (OpponentDefend(cardToToss))
                {
                    cardPair++;
                }
                else
                {
                    ShowCards();
                    cardPair = 0;
                    foreach (Control control in playerCardsPanel.Controls)
                    {
                        if (control is PictureBox pictureBox)
                        {
                            pictureBox.Click += Card_To_Attack_Click; // Додаємо обробник події для картки
                        }
                    }
                }
            }
            else
            {
                // Якщо картка не підходить, не дозволяємо її кидати
                MessageBox.Show("Цю картку не можна кинути.");
            }
        }
    }

    private Card CardToBeatPlayer(Card cardToBeat)
    {
        // звичайну карту одної масті
        foreach (Card card in opponentCards)
        {
            if (card.Suit == cardToBeat.Suit && card.Rank > cardToBeat.Rank)
            {
                return card;
            }
        }

        // якщо не знайшли одної масті, шукаєм козирну
        foreach (Card card in opponentCards)
        {
            if (card.Suit == opponentSuit)
            {
                if (card.Suit == cardToBeat.Suit && card.Rank > cardToBeat.Rank)
                {
                    return card;
                }
            }
        }

        return default;
    }

    private bool OpponentDefend(Card playerCard)
    {
        Card defendingCard = CardToBeatPlayer(playerCard);

        // Якщо знайшли карту для відбивання (не дефолт)
        if (defendingCard.Rank != 0)
        {
            // Логіка для кидання карти противником
            var targetLocation = cardPair < 3
                ? new Point(540 - (170 * cardPair), 200)
                : new Point(540 - (170 * (cardPair - 2)), 10);

            PictureBox newCard = new PictureBox
            {
                Image = Image.FromFile(defendingCard.ImagePath),
                SizeMode = PictureBoxSizeMode.AutoSize,
                Location = targetLocation,
                Tag = defendingCard.ImagePath
            };

            this.Controls.Add(newCard);
            newCard.BringToFront();

            opponentCards.Remove(defendingCard);
            tableCards.Add(defendingCard);
            cardsToBeat.Add(defendingCard);
            if (opponentCards.Count == 0)
            {
                MessageBox.Show("Ви програли!");
            }

            return true;
        }

        // Противник не може побити карту
        MessageBox.Show("Противник не може побити вашу карту і бере їх собі!");

        // Просте перенесення карт зі столу назад до противника
        foreach (Card card in tableCards)
        {
            opponentCards.Add(card);
        }

        // Видаляємо карти зі столу (форму)
        foreach (Control control in this.Controls.OfType<Control>().ToList())
        {
            if (control is PictureBox)
            {
                if (tableCards.Any(card => card.ImagePath == control.Tag.ToString()))
                {
                    this.Controls.Remove(control);
                }
            }
        }

        tableCards.Clear();
        cardsToToss.Clear();
        cardsToBeat.Clear();
        cardPair = 0;
        return false;
    }
    
    private void StartGame()
    {
        DeleteControls("title", "startButton");
        suitChoicePanel.Visible = false;

        Button exitButton = FindControl("exitButton") as Button;
        exitButton.Location = new Point(ClientSize.Width - exitButton.Width - 10,
            ClientSize.Height - exitButton.Height - 10);


        Shuffle(cards);
        playerCards = cards.GetRange(0, cards.Count / 2);
        opponentCards = cards.GetRange(cards.Count / 2, cards.Count - cards.Count / 2);

        //вибірка масті 
        if (playerSuit == Suits.Spades || playerSuit == Suits.Clubs)
        {
            opponentSuit = (Suits)rnd.Next((int)Suits.Diamonds, (int)Suits.Hearts + 1);
        }
        else
        {
            opponentSuit = (Suits)rnd.Next((int)Suits.Spades, (int)Suits.Clubs + 1);
        }

        var playerSuitIconPath = playerSuit switch
        {
            Suits.Spades => "піка.png",
            Suits.Hearts => "чирва.png",
            Suits.Clubs => "трефа.png",
            _ => "бубна.png"
        };
        var opponentSuitIconPath = opponentSuit switch
        {
            Suits.Spades => "піка.png",
            Suits.Hearts => "чирва.png",
            Suits.Clubs => "трефа.png",
            _ => "бубна.png"
        };

        PictureBox playerSuitIcon = new PictureBox
        {
            Image = Image.FromFile(playerSuitIconPath),
            Location = new Point(0, ClientSize.Height - playerCardsPanel.Height - 142),
            SizeMode = PictureBoxSizeMode.AutoSize,
            Tag = playerSuitIconPath
        };

        PictureBox opponentSuitIcon = new PictureBox
        {
            Image = Image.FromFile(opponentSuitIconPath),
            Location = new Point(0, 0),
            SizeMode = PictureBoxSizeMode.AutoSize,
            Tag = opponentSuitIconPath
        };
        Controls.Add(playerSuitIcon);
        Controls.Add(opponentSuitIcon);
        ShowCards();
        PlayerMove();
    }

    private static void Shuffle<T>(List<T> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rnd.Next(n + 1);
            (list[k], list[n]) = (list[n], list[k]);
        }
    }


    private Control FindControl(string tag)
    {
        return Controls.Cast<Control>().FirstOrDefault(control => (string)control.Tag == tag);
    }

    private void DeleteControls(params string[] tags)
    {
        foreach (string tag in tags)
        {
            Control control = FindControl(tag);
            Controls.Remove(control);
        }
    }

    private void ExitButton_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void StartButton_Click(object sender, EventArgs e)
    {
        (FindControl("suitChoice") as Panel).Visible = true;
    }

    private void DiamondsButton_Click(object sender, EventArgs e)
    {
        playerSuit = Suits.Diamonds;
        StartGame();
    }

    private void HeartsButton_Click(object sender, EventArgs e)
    {
        playerSuit = Suits.Hearts;
        StartGame();
    }

    private void SpadesButton_Click(object sender, EventArgs e)
    {
        playerSuit = Suits.Spades;
        StartGame();
    }

    private void ClubsButton_Click(object sender, EventArgs e)
    {
        playerSuit = Suits.Clubs;
        StartGame();
    }
    
    public Form1()
    {
        InitializeComponent();
    }

    private void BeatenButton_Click(object sender, EventArgs e)
    {
        (FindControl("beatenButton") as Button).Visible = false;
        (FindControl("takeCardsButton") as Button).Visible = true;
        if (tableCards.Count > 0)
        {
            foreach (Control pictureBox in this.Controls.OfType<Control>().ToList())
            {
                if (pictureBox is PictureBox)
                {
                    if (tableCards.Any(card => card.ImagePath == pictureBox.Tag.ToString()))
                    {
                        this.Controls.Remove(pictureBox);
                    }
                }
            }

            // Очищаємо список карт на столі
            tableCards.Clear();
            cardsToToss.Clear();
            cardsToBeat.Clear();

            cardPair = 0;

            ShowCards();
            foreach (Control control in playerCardsPanel.Controls)
            {
                if (control is PictureBox pictureBox)
                {
                    pictureBox.Click += Card_To_Defend_Click; // Додаємо обробник події для картки
                }
            }

            // Можна зробити перехід до ходу противника або іншої частини гри
        }
        else
        {
            // Якщо на столі немає карт, повідомляємо користувача
            MessageBox.Show("Немає карт на столі для того, щоб їх забрати.");
        }

        OpponentMove();
    }

    private bool OpponentMove()
    {
        if (opponentCards.Count == 0)
        {
            MessageBox.Show("Ви програли!");
            return false;
        }

        List<Card> availableCards;
        if (tableCards.Count != 0)
        {
            availableCards = opponentCards
                .Where(card => tableCards.Any(tc => tc.Rank == card.Rank))
                .ToList();
        }
        else
        {
            availableCards = opponentCards;
        }

        if (availableCards.Count > 0)
        {
            Card cardToToss;
            if (tableCards.Count == 0)
            {
                cardToToss = availableCards.First();
            }
            else
            {
                cardToToss = availableCards
                    .FirstOrDefault(card =>
                        cardsToToss.Any(tossCard => tossCard.Rank == card.Rank) &&
                        cardsToBeat.Any(beatCard => beatCard.Rank == card.Rank));

                if (availableCards.Count == 0 || cardPair == 0)
                {
                    MessageBox.Show("Бито");
                    return false;
                }
            }


            var targetLocation = cardPair < 3
                ? new Point(500 - (170 * cardPair), 200)
                : new Point(500 - (170 * (cardPair - 2)), 10);

            PictureBox newCard = new PictureBox
            {
                Image = Image.FromFile(cardToToss.ImagePath),
                SizeMode = PictureBoxSizeMode.AutoSize,
                Location = targetLocation,
                Tag = cardToToss.ImagePath
            };

            this.Controls.Add(newCard);
            newCard.BringToFront();

            tableCards.Add(cardToToss);
            opponentCards.Remove(cardToToss);
            cardsToToss.Add(cardToToss);
            opponentCardToToss = cardToToss;
            return true;
        }
        else
        {
            MessageBox.Show("Бито!");
            return false;
        }
    }

    private bool CardCanBeat(Card cardToBeat)
    {
        if (cardToBeat.Rank > opponentCardToToss.Rank && cardToBeat.Suit == opponentCardToToss.Suit)
            return true;

        if (cardToBeat.Suit == playerSuit)
        {
            if (opponentCardToToss.Suit != playerSuit)
            {
                return true;
            }

            if (cardToBeat.Rank > opponentCardToToss.Rank)
                return true;
        }

        return false;
    }

    private void Card_To_Defend_Click(object sender, EventArgs e)
    {
        selectedCard = sender as PictureBox;
        if (selectedCard != null)
        {
            // Знаходимо картку, що відповідає цьому зображенню
            string imagePath = selectedCard.Tag as string;
            Card cardToBeat = FindCard(imagePath);

            // Перевіряємо, чи карта можна кинути
            if (CardCanBeat(cardToBeat))
            {
                // Якщо карта може бути кинута, переносимо її на стіл
                var targetLocation = cardPair < 3
                    ? new Point(540 - (170 * cardPair), 200)
                    : new Point(540 - (170 * (cardPair - 2)), 10);

                // Створюємо нову картку (копія) для додавання на форму
                PictureBox newCard = new PictureBox
                {
                    Image = selectedCard.Image,
                    SizeMode = PictureBoxSizeMode.AutoSize,
                    Location = targetLocation, // Встановлюємо координати
                    Tag = selectedCard.Tag // Копіюємо дані картки
                };

                // Додаємо нову картку на форму
                this.Controls.Add(newCard);

                // Переміщаємо нову картку на передній план
                newCard.BringToFront();

                // Видаляємо картку з панелі
                selectedCard.Parent.Controls.Remove(selectedCard);

                // Видаляємо картку з колекції playerCards
                playerCards.Remove(cardToBeat);

                // Додаємо картку до списку tableCards
                tableCards.Add(cardToBeat);

                // Додаємо картку до списку карт, що викидаються
                cardsToBeat.Add(cardToBeat);

                // Скидаємо вибір картки
                selectedCard.BorderStyle = BorderStyle.None;
                selectedCard = null; // Вибір картки скидається після переміщення


                if (!OpponentMove())
                {
                    ShowCards();
                    cardPair = 0;

                    foreach (PictureBox pictureBox in this.Controls.OfType<PictureBox>().ToList())
                    {
                        if (tableCards.Any(card => card.ImagePath == pictureBox.Tag.ToString()))
                        {
                            this.Controls.Remove(pictureBox);
                        }
                    }

                    // Очищаємо список карт на столі
                    tableCards.Clear();
                    cardsToToss.Clear();
                    cardsToBeat.Clear();
                }
            }
            else
            {
                // Якщо картка не підходить, не дозволяємо її кидати
                MessageBox.Show("Цю картку не можна кинути.");
                return;
            }
        }

        PlayerMove();
    }
    
    private void TakeCardsButton_Click(object sender, EventArgs e)
    {
        foreach (Card card in tableCards)
        {
            playerCards.Add(card);
        }


        // Видаляємо карти зі столу (форму)
        foreach (PictureBox control in this.Controls.OfType<PictureBox>().ToList())
        {
            if (tableCards.Any(card => card.ImagePath == control.Tag.ToString()))
            {
                this.Controls.Remove(control);
            }
        }

        tableCards.Clear();
        cardsToToss.Clear();
        cardsToBeat.Clear();
        cardPair = 0;
        cardPair = 0;

        ShowCards();
        foreach (Control control in playerCardsPanel.Controls)
        {
            if (control is PictureBox pictureBox)
            {
                pictureBox.Click += Card_To_Defend_Click; // Додаємо обробник події для картки
            }
        }

        OpponentMove();
    }
}