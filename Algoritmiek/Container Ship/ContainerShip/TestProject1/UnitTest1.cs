using System;
using System.Collections.Generic;
using NUnit.Framework;
using ContainerShip;
using ContainerShip.Logic;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void Test_If_Cooled_Containers_Are_Placed()
        {
            Container container = new Container(Container.Type.Cooled, 12345);
            Row row = new Row(0, 4);
            bool check = false;
            row.IsContainerCooled(container);
            
            foreach (Stack stack in row.Stacks)
            {
                foreach (Container Filledcontainer in stack.containers)
                {
                    if (container == Filledcontainer)
                    {
                        check = true; 
                    }
                }
            }
            //Assert
            Assert.True(check);
        }
        
        [Test]
        public void Test_If_Normal_Containers_Are_Placed()
        {
            Container container = new Container(Container.Type.Normal, 12345);
            Row row = new Row(1, 4);
            bool check = false;
            row.IsContainerNormal(container);
            
            foreach (Stack stack in row.Stacks)
            {
                foreach (Container Filledcontainer in stack.containers)
                {
                    if (container == Filledcontainer)
                    {
                        check = true; 
                    }
                }
            }
            //Assert
            Assert.True(check);
        }

        [Test]
        public void Test_If_Last_Added_Container_In_Stack_Is_Valuable()
        {
            Stack stack = new Stack();
            stack.containers.Add(new Container(Container.Type.Normal, 12345));
            stack.containers.Add(new Container(Container.Type.Valuable, 5000));

            Assert.True(stack.IsLastContainerValuable());
        }

        [Test]
        public void Check_If_Sorted_List_Is_Empty_And_Cannot_Be_Loaded()
        {
            // probeer een lege lijst toe te voegen aan een schip
            Ship ship = new Ship(1000000, 4, 4);
            List<Container>container = new List<Container>();
            ContainerSort containerSort = new ContainerSort(container);
            
            Assert.False(containerSort.AllowedToLoadContainers(container));
        }
        
        [Test]
        public void Check_If_Container_Weight_Is_To_Few_Or_To_High()
        {
            Ship ship = new Ship(1000000, 4, 4);
            List<Container>container = new List<Container>();
            container.Add(new Container(Container.Type.Normal, 30001));
            container.Add(new Container(Container.Type.Normal, 3999));
            ContainerSort containerSort = new ContainerSort(container);
            
            Assert.False(containerSort.AllowedToLoadContainers(container));
        }

        [Test]
        public void Places_the_very_first_container_on_the_left()
        {
            Ship ship = new Ship(10, 2, 2);
            var container = new Container(weight: 4000);
            Row row = new Row(2,2);
            // act
            

            // assert
            Assert.AreEqual(ship.Rows[0].Stacks[0].containers[0], container);
        }
        

        [Test]
        public void Places_a_container_on_the_right_side()
        {
            Ship ship = new Ship(10, 2, 2);
            var leftContainer = new Container(weight: 4000);
            var rightContainer = new Container(weight: 4000);
            
            
        
            Assert.AreEqual(ship.Rows[0].Stacks[1].containers[0], rightContainer);
        }
        

        [Test]
        public void Can_Ship_Departure_If_Ship_Is_Under_MinimumWeight()
        {
            Ship ship = new Ship(100000, 2, 2);
            List<Container> containers = new List<Container>();
            containers.Add(new Container(Container.Type.Normal, 30000));
            containers.Add(new Container(Container.Type.Cooled, 19999));
            ContainerSort containerSort = new ContainerSort(containers);
            
            Assert.False(containerSort.MinimumShipWeight(ship, containers));
        }
        
    }
}