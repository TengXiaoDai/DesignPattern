function inherits(subConstructor, superConstructor) {
    var proto = Object.create(
        superConstructor.prototype,
        {
            "constructor": { 
                configurable: true,
                enumerable: false,
                writable: true,
                value: subConstructor
            }
        }
    );
    Object.defineProperty(subConstructor, "prototype",  { 
        configurable: true,
        enumerable: false,
        writable: true,
        value: proto
    });
}

var server = server || {};
/// <summary>The Adapter class as defined in AdapterModel.Adapter</summary>
server.Adapter = function() {
};

inherits(Adapter, Target);/// <summary>The Target class as defined in AdapterModel.Target</summary>
server.Target = function() {
};

