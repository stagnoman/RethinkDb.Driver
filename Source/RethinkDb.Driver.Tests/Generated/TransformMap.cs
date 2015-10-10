




//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Ast;
using NUnit.Framework;
using RethinkDb.Driver.Tests;

namespace RethinkDb.Driver.Test.Generated {
    [TestFixture]
    public class TransformMap : GeneratedTest {



        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, transform/map.yaml, #1
                 /* ExpectedOriginal: STREAM */
                 var expected_ = "STREAM";
                 
                 /* Original: r.range().map(r.range(), lambda x, y:(x, y)).type_of() */
                 var obtained = runOrCatch( r.range().map(r.range(), (x, y) => r.array(x, y)).typeOf() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, transform/map.yaml, #2
                 /* ExpectedOriginal: STREAM */
                 var expected_ = "STREAM";
                 
                 /* Original: r.range().map(r.expr([]), lambda x, y:(x, y)).type_of() */
                 var obtained = runOrCatch( r.range().map(r.expr(r.array()), (x, y) => r.array(x, y)).typeOf() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, transform/map.yaml, #3
                 /* ExpectedOriginal: ARRAY */
                 var expected_ = "ARRAY";
                 
                 /* Original: r.expr([]).map(r.expr([]), lambda x, y:(x, y)).type_of() */
                 var obtained = runOrCatch( r.expr(r.array()).map(r.expr(r.array()), (x, y) => r.array(x, y)).typeOf() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, transform/map.yaml, #4
                 /* ExpectedOriginal: [0, 0, 0] */
                 var expected_ = r.array(0L, 0L, 0L);
                 
                 /* Original: r.range(3).map(lambda:0) */
                 var obtained = runOrCatch( r.range(3L).map(() => 0L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             
             TestCounter++;
             
             {
                 //JavaQuery, transform/map.yaml, #6
                 /* ExpectedOriginal: [[1]] */
                 var expected_ = r.array(r.array(1L));
                 
                 /* Original: r.expr([1]).map(lambda x:(x,)) */
                 var obtained = runOrCatch( r.expr(r.array(1L)).map(x => r.array(x)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, transform/map.yaml, #7
                 /* ExpectedOriginal: [[1, 1]] */
                 var expected_ = r.array(r.array(1L, 1L));
                 
                 /* Original: r.expr([1]).map(r.expr([1]), lambda x, y:(x, y)) */
                 var obtained = runOrCatch( r.expr(r.array(1L)).map(r.expr(r.array(1L)), (x, y) => r.array(x, y)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, transform/map.yaml, #8
                 /* ExpectedOriginal: [[1, 1, 1]] */
                 var expected_ = r.array(r.array(1L, 1L, 1L));
                 
                 /* Original: r.expr([1]).map(r.expr([1]), r.expr([1]), lambda x, y, z:(x, y, z)) */
                 var obtained = runOrCatch( r.expr(r.array(1L)).map(r.expr(r.array(1L)), r.expr(r.array(1L)), (x, y, z) => r.array(x, y, z)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, transform/map.yaml, #11
                 /* ExpectedOriginal: [] */
                 var expected_ = r.array();
                 
                 /* Original: r.range().map(r.expr([]), lambda x, y:(x, y)) */
                 var obtained = runOrCatch( r.range().map(r.expr(r.array()), (x, y) => r.array(x, y)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, transform/map.yaml, #12
                 /* ExpectedOriginal: [[1, 1], [2, 2]] */
                 var expected_ = r.array(r.array(1L, 1L), r.array(2L, 2L));
                 
                 /* Original: r.expr([1, 2]).map(r.expr([1, 2, 3, 4]), lambda x, y:(x, y)) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L)).map(r.expr(r.array(1L, 2L, 3L, 4L)), (x, y) => r.array(x, y)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, transform/map.yaml, #13
                 /* ExpectedOriginal: [[0, 0], [1, 1]] */
                 var expected_ = r.array(r.array(0L, 0L), r.array(1L, 1L));
                 
                 /* Original: r.range(2).map(r.range(4), lambda x, y:(x, y)) */
                 var obtained = runOrCatch( r.range(2L).map(r.range(4L), (x, y) => r.array(x, y)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, transform/map.yaml, #14
                 /* ExpectedOriginal: [[0, 1], [1, 2], [2, 3], [3, 4]] */
                 var expected_ = r.array(r.array(0L, 1L), r.array(1L, 2L), r.array(2L, 3L), r.array(3L, 4L));
                 
                 /* Original: r.range().map(r.expr([1, 2, 3, 4]), lambda x, y:(x, y)) */
                 var obtained = runOrCatch( r.range().map(r.expr(r.array(1L, 2L, 3L, 4L)), (x, y) => r.array(x, y)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, transform/map.yaml, #15
                 /* ExpectedOriginal: [[0, 0], [1, 1], [2, 2]] */
                 var expected_ = r.array(r.array(0L, 0L), r.array(1L, 1L), r.array(2L, 2L));
                 
                 /* Original: r.range(3).map(r.range(5), r.js("(function(x, y){return [x, y];})")) */
                 var obtained = runOrCatch( r.range(3L).map(r.range(5L), r.js("(function(x, y){return [x, y];})")) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, transform/map.yaml, #16
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "Cannot convert NUMBER to SEQUENCE", []) */
                 var expected_ = err("ReqlQueryLogicError", "Cannot convert NUMBER to SEQUENCE", r.array());
                 
                 /* Original: r.range().map(r.expr(1), lambda x, y:(x, y)) */
                 var obtained = runOrCatch( r.range().map(r.expr(1L), (x, y) => r.array(x, y)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, transform/map.yaml, #17
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "Cannot use an infinite stream with an aggregation function (`reduce`, `count`, etc.) or coerce it to an array.", []) */
                 var expected_ = err("ReqlQueryLogicError", "Cannot use an infinite stream with an aggregation function (`reduce`, `count`, etc.) or coerce it to an array.", r.array());
                 
                 /* Original: r.range().map(r.range(), lambda x, y:(x, y)).count() */
                 var obtained = runOrCatch( r.range().map(r.range(), (x, y) => r.array(x, y)).count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, transform/map.yaml, #18
                 /* ExpectedOriginal: [[0], [1], [2]] */
                 var expected_ = r.array(r.array(0L), r.array(1L), r.array(2L));
                 
                 /* Original: r.map(r.range(3), lambda x:(x,)) */
                 var obtained = runOrCatch( r.map(r.range(3L), x => r.array(x)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, transform/map.yaml, #20
                 /* ExpectedOriginal: [[0, 0], [1, 1], [2, 2]] */
                 var expected_ = r.array(r.array(0L, 0L), r.array(1L, 1L), r.array(2L, 2L));
                 
                 /* Original: r.map(r.range(3), r.range(5), lambda x, y:(x, y)) */
                 var obtained = runOrCatch( r.map(r.range(3L), r.range(5L), (x, y) => r.array(x, y)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             

        }
    }
}